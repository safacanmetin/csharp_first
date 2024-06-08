using System;
using System.Threading;

class Greeting
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Nice to meet you, " + name + "!");

        Console.WriteLine("Press any key to close...");
        Console.ReadKey();
    }
}