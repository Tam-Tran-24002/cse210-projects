using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        if (grade >= 90)
        {
       letter = "A";
        }
        else if (grade >= 80)
        {   
        letter = "B";
        }
        else if (grade >= 70)
        {   
        letter = "C";
        }
        else if (grade >= 60)
        {   
        letter = "D";
        }
       else
        {
        letter = "F";
        }
            Console.WriteLine($"Your grade is {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Keep trying, you'll get it next time!");
        }
    }
}