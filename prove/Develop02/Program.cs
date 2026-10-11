// Exceeding requirements:
// - Menu input is validated with try/catch so typing letters doesn't crash the program
// - Loading a file that doesn't exist shows a friendly message instead of crashing
// Help received: debugging help from Google

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();

        int response = 0;

        while (response != 5)
        {
            response = myMenu.ProcessMenu();

            switch (response)
            {
                case 1:
                    myJournal.CreateEntry();
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.Write("What is the filename? ");
                    myJournal.WriteToFile(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("What is the filename? ");
                    try
                    {
                        myJournal.ReadFromFile(Console.ReadLine());
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("That file does not exist.");
                    }
                    break;
            }
        }
    }
}