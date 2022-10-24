namespace SimpleConsole.Core.Actions
{
    public class ConsoleAction : IConsoleAction
    {
        public Action Action { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsExit { get; }
        public ConsoleAction(Action action, string name, string description, bool isExit)
        {
            this.Action = action;
            this.Name = name;
            this.Description = description;
            this.IsExit = isExit;
        }
    }
}
