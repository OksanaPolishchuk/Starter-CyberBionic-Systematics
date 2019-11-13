using System;
namespace Lesson6Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение (первое значение < второе значение)");
            string z = Console.ReadLine();
            double a;
            double.TryParse(z, out a);

            Console.WriteLine("Введите второе значение");
            string x = Console.ReadLine();
            double b;
            double.TryParse(x, out b);

            double summ = 0;
            double c = 0;

            for (c = a + 1; c < b; c++)
            {
                summ += c;
                if (c % 2 - 0.1 > 0.000001)
                {
                    Console.WriteLine("Нечетное число {0}", c);
                }
            }
            Console.WriteLine("Cумма всех чисел: {0}", summ);

            Console.ReadKey();

        }
    }
}
