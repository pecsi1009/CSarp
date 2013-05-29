using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.TheSurfaceOfTriangle
{
    class TheSurfaceOfTriangle
    {
        static void Main()
        {
            Console.Write("Enter value for side a =");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter value for side b =");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter value for side c =");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter value for altitude ha =");
            double ha = double.Parse(Console.ReadLine());
            Console.Write("Enter value for angle =");
            double angle = double.Parse(Console.ReadLine());

            Surface1(a, ha);
            Surface2(a, b, c);
            Surface3(a, b, angle);

        }

        private static void Surface3(double a, double b, double angle)
        {
            double pi = Math.PI;
            double sin = Math.Sin((angle * pi) / 180);
            double s3 = ((a * b) * System.Math.Sin(sin));
            Console.WriteLine("S=(a*b*sin(angle))/2 = {0}", s3);
        }

        private static void Surface2(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s2 = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("S=Sqrt(p(p-a)(p-b)(p-c)) = {0}", s2);
        }

        private static void Surface1(double a, double ha)
        {
            double s1 = (a * ha) / 2;
            Console.WriteLine("S=(a*ha)/2 = {0}", s1);
        }
    }
}
