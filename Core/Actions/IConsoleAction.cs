namespace SimpleConsole
{
    public interface IConsoleAction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsExit { get; }
    }
}
