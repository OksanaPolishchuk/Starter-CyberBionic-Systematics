using System;

namespace Lesson5Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            
            if (A || B)        //Исходное выражение 
                Console.WriteLine("A || B = {0}", A || B);
            else
                Console.WriteLine("A || B = {0}", A || B);

            if (!(!A && !B))   //Эквивалентное выражение 
                Console.WriteLine("!(!A && !B) = {0}", !(!A && !B));
            else
                Console.WriteLine("!(!A && !B) = {0}", !(!A && !B));

            Console.ReadKey();

        }
    }
}
