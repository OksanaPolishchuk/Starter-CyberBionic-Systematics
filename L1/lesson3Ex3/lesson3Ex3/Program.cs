using System;
using System.Text;
using System.Threading.Tasks;

namespace lesson3Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double r = 6, y = 2;
            double result = Math.Pow(r, y);
            double s = pi * result;

            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
