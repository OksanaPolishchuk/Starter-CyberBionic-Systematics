using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6Additionally
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 15; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int c = 0; c < 7; c++)
            {
                for (int d = 0; d < 20; d++)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
