using System;

    class ReadsCalculatePrintInt
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter integer number: ");
                double number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArithmeticException("Invalid number!!! Please enter positive number!!!");
                }

                double result = Math.Sqrt(number);
                System.Console.WriteLine(result);
            }
            catch(FormatException fe)
            {
                throw new FormatException("Invalid number"+fe.Message);

            }
            catch(OverflowException)
            {
               System.Console.WriteLine("Input number is too small or big");
            }
            finally
            {
                System.Console.WriteLine("Good bye!!!");

            }
        }
    }

