using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from main branch!");
        GreetUser("User");
        GreetUser("Maksym");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}