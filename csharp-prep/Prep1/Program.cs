using System;

class Program
{
    static void Main(string[] args)
    {   
        string firstName;
        string lastName;
        Console.WriteLine("Please enter your first name: ");
        firstName = Console.ReadLine();
        Console.WriteLine("Hey Tam,");
        Console.WriteLine("Please enter your last name: ");
        lastName = Console.ReadLine();
        Console.WriteLine($"Hey {firstName} {lastName}, welcome to the program!");

    }
}