// singleton
// singleton pattern
// singleton pattern in c#
// singleton pattern in c# example

using System;
using SingletonProject;

Console.Title = "Singleton Pattern Example";
Logger singleton1 = Logger.Instance();
Logger singleton2 = Logger.Instance();

if (singleton1 == singleton2)
{
    Console.WriteLine("Both objects are the same instance.");
}
else
{
    Console.WriteLine("Both objects are different instances.");
}
