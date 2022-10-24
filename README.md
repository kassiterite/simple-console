# SimpleConsole
 
 Example:
``` C#
using SimpleConsole;
using SimpleConsole.Core.Actions;
ConsoleHandler ch = new ConsoleHandler();
ConsoleAction exit = new(() => Console.WriteLine("Exiting... Bye!"), "exit", "exiting", true);
ch.AddConsoleAction(exit);
ch.AddConsoleAction(new ConsoleAction(() => Console.Beep(),"beep","console do beep", false));
ch.InvokeConsole();
```
