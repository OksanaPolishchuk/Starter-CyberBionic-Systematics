using System;

namespace Lesson5Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Method 2
             
                 x += y >> x++ * z; 
                 z = ++x & y * 5; 
                 y /= x + 5 | z; 
                 z = x++ & y * 5; 
                 x = y << x++ ^ z; */

            int x = 5, y = 10, z = 15;

                x = x + y >> (x++ * z);

                Console.WriteLine(x);

                z = ++x & (y * 5);

                Console.WriteLine(z);
            
            
                y = y /= ((x + 5) | z);

                Console.WriteLine(y);
            
            
                z = x++ & (y * 5);

                Console.WriteLine(z);
           
            
                x = (y << x++) ^ z;

                Console.WriteLine(x);

            Console.ReadKey();

            
        }
    }
}
