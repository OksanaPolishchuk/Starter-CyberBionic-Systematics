using System;
using System.Xml;

namespace lesson3Ex1
{
    class Program
    {
        static void Main(string[] args)


        {
            { 
                
                int x = 10;
                int y = 12;
                int z = 3;

                // x += y - x++ * z

               int result = x + (y - x++ * z);

                Console.WriteLine(result);
 
                // second option

                /*
                int result1 = y - x++ * z;
                int result2 = x + result1;

                Console.WriteLine(result2); output -7 
                */
            }
            {
                // z = --x - y * 5

                int x = 10;
                int y = 12;
                int z = 3;

                z = --x - y * 5;

                Console.WriteLine(z);
            }
            {
                // y /= x + 5 % z
                // y = y / (x + 5 % z)

                int x = 10;
                int y = 12;
                int z = 3;

                y = y / (x + 5 % z);

                Console.WriteLine(y);
            }
            {
                // z = x++ + y * 5

                int x = 10;
                int y = 12;
                int z = 3;

                z = x++ + y * 5;

                Console.WriteLine(z);

                // second option

                // z = x++ + y * 5
                /* 
                int x = 10;
                int y = 12;
                int z = 3;
                
                Console.WriteLine(x++);

                z = x++ + y * 5;

                Console.WriteLine(z); output 71
                */
            }
            {
                // x = y - x++ * z

                int x = 10;
                int y = 12;
                int z = 3;


                x = y - x++ * z;

                Console.WriteLine(x);

                // second option

                // x = y - x++ * z
                
                /*
                 int x = 10;
                 int y = 12;
                 int z = 3;

                Console.WriteLine(x++);

                x = y - x++ * z;

                Console.WriteLine(x); output 21
                */ 
                Console.ReadKey();

            }
        }
    }
}
