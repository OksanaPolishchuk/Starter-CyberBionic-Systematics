using System;

namespace Lesson6Ex4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many customers?");
            string a = Console.ReadLine();
            int customers = 0;
            int.TryParse(a, out customers);
            int delivery = 1;

            Console.Write("Delivery options: {0}!=", customers);
            do
            {
                delivery *= customers--;
            }
            while (customers > 0);
            Console.WriteLine("{0}", delivery);

            Console.ReadKey();
        }
    }
}
