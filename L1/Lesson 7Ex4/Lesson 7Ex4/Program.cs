using System;
namespace Lesson_7Ex4
{
    class Program
    {
        static void Check(double b)
        {
            if (b > 0)
            {
                Console.WriteLine("Bведенное число положительное");

                bool isPrime = true;

                for (int i = 2; i <= b / 2 && isPrime; ++i)
                {
                    if (b % i == 0) isPrime = false;
                }

                if (isPrime)
                    Console.WriteLine("Простое число {0}", b);
                else
                {
                    Console.WriteLine("Составное число {0}", b);
                }
            }
            else if (b < 0)
            {
                Console.WriteLine("Bведенное число отрицательное");
            }

            if (b == 0)
            {
                Console.WriteLine("Беззнаковoе числo");
                Console.WriteLine(
                    "Ноль не является натуральным числом и, соответственно, не является ни простым, ни составным.");
            }

            string dividers = "";
            if (b % 2 == 0)
            {
                dividers += "2 ";
            }

            if (b % 5 == 0)
            {
                dividers += "5 ";
            }

            if (b % 9 == 0 || b % 6 == 0)
            {
                dividers += "3 ";
                if (b % 6 == 0)
                {
                    dividers += "6 ";
                }

                if (b % 9 == 0)
                {
                    dividers += "9 ";
                }
            }

            if (dividers != "")
            {
                Console.WriteLine(" Делится без остатка на " + dividers);
            }
            else
                Console.WriteLine("Не делится на 2,3,5,6 и 9 без остатка.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число.");
            string a = Console.ReadLine();
            int b = Convert.ToInt16(a);
            Check(b);
            Console.ReadKey();
        }
    }
}