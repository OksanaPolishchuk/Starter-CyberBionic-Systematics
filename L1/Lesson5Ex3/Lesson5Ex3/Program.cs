using System;

namespace Lesson5Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   x += y >> x++ * z; 
                 z = ++x & y * 5; 
                 y /= x + 5 | z; 
                 z = x++ & y * 5; 
                 x = y << x++ ^ z; */
            {
                int x = 5, y = 10, z = 15;

                x = x + y >> (x++ * z);

                Console.WriteLine(x);
            }
            {
                int x = 5, y = 10, z = 15;

                z = ++x & (y * 5);

                Console.WriteLine(z);
            }
            {
                int x = 5, y = 10, z = 15;

                y /= ((x + 5) | z);

                Console.WriteLine(y);
            }
            {
                int x = 5, y = 10, z = 15;

                z = x++ & (y * 5);

                Console.WriteLine(z);
            }
            {
                int x = 5, y = 10, z = 15;
                x = (y << x++) ^ z;

                Console.WriteLine(x);

                Console.ReadKey();

            }
        }
    }
}
