using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square( "Red", 18.5));
        shapes.Add(new Rectangle( "Blue", 12.6, 21.9));
        shapes.Add(new Circle( "Green", 13.3));

        int index = 0;
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape {index + 1}");
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}\n");
            index++;
        }

       
    }
}