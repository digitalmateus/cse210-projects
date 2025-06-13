using System;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("Red", 5.5);
        //Console.WriteLine($"Square Area: {square.GetArea()} and color: {square.GetColor()}");
        //square.SetColor("Blue");

        Rectangle rectangle = new Rectangle("Brown",4.0, 6.0);
        //Console.WriteLine($"Rectangle Area: {rectangle.GetArea()} and color: {rectangle.GetColor()}");
        //rectangle.SetColor("Green");

        Circle circle = new Circle("Orange", 3.0);
        //Console.WriteLine($"Circle Area: {circle.GetArea()} and color: {circle.GetColor()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Yellow", 2.0));
        shapes.Add(new Rectangle("Black", 3.0, 4.0));
        shapes.Add(new Circle("White", 5.0));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()} and Area: {shape.GetArea()}");
        }

    }
}