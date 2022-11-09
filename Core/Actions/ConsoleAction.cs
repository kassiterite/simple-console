namespace SimpleConsole
{
    public class ConsoleAction : IConsoleAction
    {
        public Action Action { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsExit { get; }
        public ConsoleAction(Action action, string name, string description, bool isExit)
        {
            Action = action;
            Name = name;
            Description = description;
            IsExit = isExit;
        }
    }
}