using System;

class Program
{
    static void Main(string[] args)
    {   

        Console.WriteLine("Please enter your first name: ");
        string first = Console.ReadLine();

        Console.WriteLine("Please enter your last name: ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");

    }
}