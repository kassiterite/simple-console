namespace SimpleConsole
{
    public class ConsoleReadAction : IConsoleAction
    {
        public Action<string> Action { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsExit { get; }
        public ConsoleReadAction(Action<string> action, string name, string description, bool isExit)
        {
            Action = action;
            Name = name;
            Description = description;
            IsExit = isExit;
        }
    }
}
