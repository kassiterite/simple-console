namespace SimpleConsole.Core.Extensions
{
    internal static class PredicateExtensions
    {
        internal static void CompleteIfTrue(this Func<bool> predicate, Action action)
        {
            if(predicate.Invoke())
                action();
        }
    }
}
