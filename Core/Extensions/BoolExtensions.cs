namespace SimpleConsole.Core.Extensions
{
    internal static class BoolExtensions
    {
        internal static void CompleteIfTrue(this bool isTrue, Action action)
        {
            if (isTrue) 
                action();
        }
    }
}
