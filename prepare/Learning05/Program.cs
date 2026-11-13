using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test the Square class on its own first
        Square testSquare = new Square("Red", 3);
        Console.WriteLine($"Test square -> Color: {testSquare.GetColor()}, Area: {testSquare.GetArea()}");
        Console.WriteLine();

        // Build a list of base-class Shapes holding different derived shapes
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 3));
        shapes.Add(new Rectangle("Blue", 4, 5));
        shapes.Add(new Circle("Green", 6));

        // Polymorphism: the same call runs a different GetArea() for each shape
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:0.00}.");
        }
    }
}