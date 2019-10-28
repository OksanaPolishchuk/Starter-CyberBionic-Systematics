using System;
using System.Threading.Tasks;

namespace lesson3Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // v = pi*r2*h
            // s = 2*pi*r2+2*pi*r*h = 2*pi*r(r+h)

            const double pi = 3.14;
            byte h = 2; 
            double r = 4, y = 2;
            double result = Math.Pow(r, y);

            double v = pi * result * h;

            Console.WriteLine(v);

            // s = 2*pi*r(r+h)

            double s1 = 2 * pi * r * (r + h);

            Console.WriteLine(s1);

            // s = 2*pi*r2+2*pi*r*h 

            double s2 = 2 * pi * result + 2 * pi * r * h;

            Console.WriteLine(s2);

            Console.ReadKey();

        }
    }
}
