using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramForShapes
{
    class Program
    {
        static void Main()
        {
            Shape[] shapes = {
                                  new Triangle(5,2),
                                  new Rectangle(18,4),
                                  new Circle(3,4),
                                  new Circle(2,2),                          
                            };
            foreach (var shape in shapes)
            {
                Console.Write(shape.GetType());
                Console.Write(" surface = ");
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
