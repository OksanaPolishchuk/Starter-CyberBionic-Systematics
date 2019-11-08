using System;
namespace Lesson5Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //x += y >> x++ * z;
            {
                int x = 5;
                int y = 10;
                int z = 15;

                int result1 = ((x += y) >> x++) * z;

                Console.WriteLine(result1);
            }
            //  z = ++x & y * 5;
            {
                int x = 5;
                int y = 10;
                int z = 15;

                int result2 = (++x & y) * 5;

                Console.WriteLine(result2);
            }
            //  y /= x + 5 | z;
            {
                int x = 5;
                int y = 10;
                int z = 15;

                int result3 = (y /=(x + 5)) | z;

                Console.WriteLine(result3);
            }
            // z = x++ & y * 5
            {
                int x = 5;
                int y = 10;
                int z = 15;

                int result4 = (z = (x++ & y)) * 5;

                Console.WriteLine(result4);
            }
            //x = y << x++ ^ z
            {
                int x = 5;
                int y = 10;
                int z = 15;

                int result5 = (x = (y << x++)) ^ z;

                Console.WriteLine(result5);
            }
            Console.ReadKey();
        }
    }
}
