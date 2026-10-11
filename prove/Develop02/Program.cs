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