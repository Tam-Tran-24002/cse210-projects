using System;

class Menu
{
    public int ProcessMenu()
    {
        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input must be an integer value between 1 and 5.");
            }
        }

        return input;
    }
}