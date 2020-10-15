using System;
using System.Collections.Generic;
using System.Globalization;
using Inheritance2.Entities;
using Inheritance2.Entities.Enums;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"SHAPE #{i+1} DATA: ");
                Console.Write("Rectangle or circle (r/c)? ");
                char verification = char.Parse(Console.ReadLine());
                Console.Write("Color (Black,Red or Blue): ");
                Color color = Enum.Parse < Color > (Console.ReadLine()); 
                if (verification == 'r')
                {
                    Console.Write("Widgth: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(color,radius));
                }
            }
            Console.WriteLine();

            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
            }


        }
    }
}
