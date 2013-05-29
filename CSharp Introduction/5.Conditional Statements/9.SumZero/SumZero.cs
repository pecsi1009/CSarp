using System;

class SumZero
{
    static void Main()
    {
        Console.Write("Enter integer number a=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number b=");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number c=");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number d=");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number e=");
        int e = int.Parse(Console.ReadLine());
        
        // 2 digits *********************************************

        if (a + b == 0)
        {
            Console.WriteLine("The sum of {0}+{1} is zero",a,b);
        }
        if (a + c == 0)
        {
            Console.WriteLine("The sum of {0}+{1} is zero",a,c);
        }
        if (a + d == 0)
        {
            Console.WriteLine("The sum of {0}+{1} is zero",a,d);
        }
        if (a + e == 0)
        {
            Console.WriteLine("The sum of {0}+{1} is zero",a,e);
        }
        if (b + c == 0)
        {
            Console.WriteLine("The sum of {0}+{1} is zero",b,c);
        }
        if (b + d == 0)
        {
            Console.WriteLine("The sum of {0}+{1} is zero",b,d);
        }
        if (b + e == 0)
        {
            Console.WriteLine("The sum of {0}+{1} is zero",b,e);
        }
        if (c + d == 0)
        {
            Console.WriteLine("The sum of {0}+{1} is zero",c,d);
        }
        if (c + e == 0)
        {
            Console.WriteLine("The sum of {0}+{1} is zero",c,e);
        }
        if (d + e == 0)
        {
            Console.WriteLine("The sum of {0}+{1} is zero",d,e);
        }

        // 3 digits **********************************************

        if (a + b + c == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2} is zero",a,b,c);
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2} is zero",a,b,d);
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2} is zero", a, b, e);
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2} is zero",b,c,d);
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2} is zero", b,d,e);
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2} is zero", c, d, e);
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2} is zero", a, c, d);
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2} is zero", a, d, e);
        }

        // 4 digits *********************************************
        if (a + b + c + d == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2}+{3} is zero", a, b, c, d);
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2}+{3} is zero", a, b, c);
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2}+{} is zero", b, c, d, e);
        }

        // 5 digits ***********************************************

        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("The sum of {0}+{1}+{2}+{3}+{4} is zero", a, b, c, d, e);
        }
        Console.WriteLine("There is no more sum of zero of these digits");
    }
}

