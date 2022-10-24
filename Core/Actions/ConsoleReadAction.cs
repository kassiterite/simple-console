namespace SimpleConsole.Core.Actions
{
    public class ConsoleReadAction : IConsoleAction
    {
        public Action<string> Action { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsExit { get; }
        public ConsoleReadAction(Action<string> action, string name, string description, bool isExit)
        {
            this.Action = action;
            this.Name = name;
            this.Description = description;
            this.IsExit = isExit;
        }
    }
}
