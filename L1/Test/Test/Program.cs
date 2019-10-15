using System;
using System.Net;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Oksana the best");
            System.Console.WriteLine(Add(5,4));
            System.Console.WriteLine(Text("Oksana"));
        }

        static int Add(int a, int b)
        {
            int c;
            c = a * 3;
            return c + b;
        }

        static string Text(string name)
        {
            return "hello " + name;
        }
    }
}
