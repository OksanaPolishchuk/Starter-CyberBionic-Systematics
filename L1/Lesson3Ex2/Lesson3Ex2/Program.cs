using System;
using System.Runtime.InteropServices;

namespace Lesson3Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 9;
            int c = 4;

            int sum = a + b +c;

            Console.WriteLine((double)sum / 3);

            Console.ReadKey();
        }
    }
}
