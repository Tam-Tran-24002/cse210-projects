class Menu
{
    public int ProcessMenu()
    {
        int input = 0;
        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Create, Display, Save or Read Journal Entries");
            Console.WriteLine("1. Create new journal entries");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Read journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("> ");

            if (!int.TryParse(Console.ReadLine(), out input))
            {
                input = 0; // non-number entered, so show the menu again
            }
        }
        return input;
    }
}