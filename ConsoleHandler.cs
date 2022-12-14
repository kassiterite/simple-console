using SimpleConsole.Core.Extensions;

namespace SimpleConsole
{
    public class ConsoleHandler
    {
        readonly List<IConsoleAction> consoleActions = new();
        public ConsoleHandler(IList<IConsoleAction> consoleActions)
        {
            this.consoleActions = (List<IConsoleAction>)consoleActions;
        }
        public ConsoleHandler() { }
        private bool ValidateAction(IConsoleAction consoleAction)
            => consoleActions.ContainsName(consoleAction.Name);
        public void AddConsoleAction(IConsoleAction consoleAction)
        {
            if (ValidateAction(consoleAction))
                throw new Exception("Console is already contains action with name {name}");
            else
                consoleActions.Add(consoleAction);
        }

        private void WriteCommands()
        {
            if (consoleActions.Count > 0)
                System.Console.WriteLine("Commands:");
            int i = 0;
            foreach (var consoleAction in consoleActions.OrderBy(x => x.Name))
            {
                Console.WriteLine($"[{++i}] {consoleAction.Name} - {consoleAction.Description}");
            }
        }

        /*        public StringBuilder ActionMap()
                {
                    StringBuilder sb = new StringBuilder();
                    foreach(var consoleAction in consoleActions.OrderBy(x => x.Name))
                    {
                        foreach(var consoleReadAction in consoleReadActions.OrderBy(x => x.Name))
                        {
                        }
                    }
                }*/
        public void InvokeConsole()
        {
            bool isWayOut = false;
            WriteCommands();
            while (!isWayOut)
            {
                string input = Console.ReadLine();

                foreach (var consoleAction in consoleActions)
                    if (consoleAction.Name == input)
                    {
                        consoleAction.IsExit.CompleteIfTrue(() => isWayOut = true);
                        (consoleAction is ConsoleAction).CompleteIfTrue(() => ((ConsoleAction)consoleAction).Action.Invoke());
                        (consoleAction is ConsoleReadAction).CompleteIfTrue(() => ((ConsoleReadAction)consoleAction).Action.Invoke(Console.ReadLine()));
                    }
                if (!consoleActions.Any(x => x.Name == input))
                {
                    Console.WriteLine("Incorrect command!");
                    WriteCommands();
                }
            }
        }
    }
}