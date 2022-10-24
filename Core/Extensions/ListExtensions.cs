using SimpleConsole.Core.Actions;

namespace SimpleConsole.Core.Extensions
{
    public static class ListExtensions
    {
        public static bool ContainsName(this List<IConsoleAction> consoleActions, string name) 
        {
            foreach (IConsoleAction consoleAction in consoleActions)
                if (consoleAction.Name == name)
                    return true;
            return false;
        }
    }
}
