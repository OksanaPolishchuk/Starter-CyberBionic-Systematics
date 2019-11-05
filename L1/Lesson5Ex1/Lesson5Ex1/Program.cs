using System;
namespace Lesson5Ex1
{
    class Program
    
    {
        static void Main(string[] args)
        { 
            byte n = 2, x = 0;
            Console.Write("Insert a number");
            string c = Console.ReadLine();
            int a = Convert.ToInt32(c);

            //Method1
            if ((a & (a - 1)) == 0)
                Console.WriteLine("Method1: The indicated number is a power of 2"); 
            else 
                Console.WriteLine("Method1: The indicated number is not a power of 2");

            //Method2
            int z = a; 
            do
            {
                z = z / 2;
                if (z == 2) 
                    Console.WriteLine("Method2: The indicated number is a power of 2");
                else if (z == 0) 
                    Console.WriteLine("Method2: The indicated number is not a power of 2"); 
            }
            while (z != 2 && z != 0);

            Console.ReadKey();
        }
    }
}
