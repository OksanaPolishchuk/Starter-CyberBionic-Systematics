using System;
namespace lesson5Ex2Additional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1

            Console.WriteLine("Введите число");
            string a = Console.ReadLine();
            Int32 z = Convert.ToInt32(a);

            if (z % 2 == 0)
                Console.WriteLine("Четное число");
            else
                Console.WriteLine("Нечетное число");

            //Method2

            int s = z;
            if ((s & 1) == 0) 
                Console.WriteLine("Четное число");
            else
                Console.WriteLine("Нечетное число");

            Console.ReadKey();
        }
    }
}
