# SimpleConsole
Download a library, use in project and be happiness!
``` C#
using SimpleConsole;
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
ConsoleHandler ch = new();
            ConsoleAction exit = 
                new(() => Console.WriteLine("Exiting... Bye!"), "exit", "exiting", true);
            ch.AddConsoleAction(exit);
            ch.AddConsoleAction(new ConsoleAction(() => Console.Beep(),"beep","console do beep", false));
            ch.AddConsoleAction(new ConsoleReadAction(x =>
                {
                    ConsoleHandler ach = new();
                    void toDouble()
                    {
                        bool isValid = double.TryParse(x, out double d);
                        if (isValid)
                            Console.WriteLine("Validation passed");
                        else
                            Console.WriteLine("Validation failed");
                    }
                    void toDateTime()
                    {
                        bool isValid = DateTime.TryParse(x, out DateTime d);
                        if (isValid)
                            Console.WriteLine("Validation passed");
                        else
                            Console.WriteLine("Validation failed");
                    }
                    ach.AddConsoleAction(new ConsoleAction(toDouble, "double", "try validate to double", false));
                    ach.AddConsoleAction(new ConsoleAction(toDateTime, "datetime", "try validate to datetime", false));
                    ach.AddConsoleAction(exit);
                    ach.InvokeConsole();
                }, "validate", "validate number convert to type", false));
            ch.InvokeConsole();
```
