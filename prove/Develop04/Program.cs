using System;
using System.Collections.Generic;

// Exceeding requirements:
// 1. Prompts and reflection questions never repeat until every one in the
//    list has been used once this session (PromptBank class).
// 2. The program keeps a session log of how many times each activity was
//    completed and the total seconds spent in it, shown when the user quits.
// 3. The duration input is validated, so typing letters, zero or a negative
//    number asks again instead of crashing.
// 4. The countdown correctly erases multi-digit numbers (e.g. 10 -> 9).

class Program
{
    static void Main(string[] args)
    {
        List<BaseActivity> activities = new List<BaseActivity>
        {
            new BreathingActivity(),
            new ReflectingActivity(),
            new ListingActivity()
        };

        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1" || choice == "2" || choice == "3")
            {
                int index = int.Parse(choice) - 1;
                activities[index].Run();
            }
        }

        Console.WriteLine();
        Console.WriteLine("Session log:");
        foreach (BaseActivity activity in activities)
        {
            Console.WriteLine($"  {activity.GetSummary()}");
        }
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
    }
}