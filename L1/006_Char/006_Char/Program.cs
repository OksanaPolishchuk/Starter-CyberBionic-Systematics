using System;
using System.Threading.Tasks;

namespace _006_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char b = '\x0061';
            char c = '\u0041';

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
