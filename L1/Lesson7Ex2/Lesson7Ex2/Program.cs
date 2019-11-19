using System;

namespace Lesson7Ex2
{
    class Program
    {
        static double Add(int a, int b, ref double sum)
        {
            return sum = a + b;
        }
        static double Sub(int a, int b, ref double sum)
        {
            return sum = a - b;
        }
        static double Mul(int a, int b, ref double sum)
        {
            return sum = a * b;
        }
        static double Div(int a, int b, ref double sum)
        {
            try
            {
                return sum = Convert.ToDouble(a) / Convert.ToDouble(b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero.");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first value");
            string z = Console.ReadLine();
            int a = 0;
            int.TryParse(z, out a);

            Console.Write("Выберите знак арифметической операции: +, -, *, /.");
            string sign = Console.ReadLine();

            Console.WriteLine("Enter the second value");
            string s = Console.ReadLine();
            int b = 0;
            int.TryParse(s, out b);

            double sum = 0;

            switch (sign)
            {
                case "+":
                    {
                        Add(a, b, ref sum);
                        Console.WriteLine("{0} + {1} = {2}", a, b, sum);
                        break;
                    }
                case "-":
                    {
                        Sub(a, b, ref sum);
                        Console.WriteLine("{0} - {1} = {2}", a, b, sum);
                        break;
                    }
                case "*":
                    {
                        Mul(a, b, ref sum);
                        Console.WriteLine("{0} * {1} = {2}", a, b, sum);
                        break;
                    }
                case "/":
                    {
                        Div(a, b, ref sum);
                        if (sum != 0) 
                            Console.WriteLine("{0} / {1} = {2}", a, b, sum);
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}




