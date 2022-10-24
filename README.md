# SimpleConsole
Using the library and write there:
``` C#
using SimpleConsole;
using SimpleConsole.Core.Actions;
```
Example with single handler:
``` C#
ConsoleHandler ch = new ConsoleHandler();
ConsoleAction exit = new(() => Console.WriteLine("Exiting... Bye!"), "exit", "exiting", true);
ch.AddConsoleAction(exit);
ch.AddConsoleAction(new ConsoleAction(() => Console.Beep(),"beep","console do beep", false));
ch.InvokeConsole();
```
Example with double handler:
``` C#
ConsoleHandler ch = new ConsoleHandler();
ConsoleAction exit = new(() => Console.WriteLine("Exiting... Bye!"), "exit", "exiting", true);
ch.AddConsoleAction(exit);
ch.AddConsoleAction(new ConsoleAction(() => Console.Beep(),"beep","console do beep", false));
ch.AddConsoleAction(new ConsoleReadAction(x =>
{
  ConsoleHandler ach = new();
  Action toDouble = () => 
  {
    try
    {
      Convert.ToDouble(x);
      Console.WriteLine("Validation passed");
    }
    catch (Exception ex)
    {
      Console.WriteLine("Validation failed");
    }};
    Action toDateTime = () =>
    {
      try
      {
        Convert.ToDateTime(x);
        Console.WriteLine("Validation passed");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Validation failed")
      }};
  ach.AddConsoleAction(new ConsoleAction(toDouble, "double", "try validate to double", false));
  ach.AddConsoleAction(new ConsoleAction(toDateTime, "datetime", "try validate to datetime", false));
  ach.AddConsoleAction(exit);
  ach.InvokeConsole();}, "validate", "validate number convert to type", false));
ch.InvokeConsole();
```
