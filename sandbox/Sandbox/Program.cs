// using System;
// using System.Diagnostics.CodeAnalysis;
// class Program
//     {
//         static double AddNumbers(double x, int y)
//         {
//             // Console.Writeline(x);
//             return x + y; 

//         }

//         static string MyName()
//     {
//         return "Bob";
//     }

//     static void DisplayGreeting(string name)
//     {
//         Console.WriteLine($"Welcome {name}, its nice to meet you");
//     }

//     static void Main(string[] args)
//     {
//         string myName = MyName();
//         DisplayGreeting(myName);
//         double total = AddNumbers(12.234, 20);
//         Console.WriteLine(total);

//     }
//     }

using System;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        myCircle. _radius = 10;
        double area = myCircle.GetArea();
        Console.WriteLine(area);
    }
}