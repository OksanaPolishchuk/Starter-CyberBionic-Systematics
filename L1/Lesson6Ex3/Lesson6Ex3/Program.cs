
using System;


namespace Lesson6Ex3

{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int a = 0; a < 7; a++)
            {
                for (int b = 0; b < 7; b++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int a = 0; a < 7; a++)
            {
                for (int b = 0; b < a; b++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int c = 0; c < 6; c++)
            {
                for (int d = 0; d < c; d++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.Write("\n");
            }
            for (int z = 0; z < 7; z++)
            {
                Console.Write("*");
            }
            Console.Write("\n");

            Console.Write("\n");
          
            for (int b = 0; b < 7; b++)
            {
                for (int c = 7; c > b; c--)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < b; a++)
                {
                    Console.Write("*");
                }
                for (int d = 0; d < b; d++)
                {
                    Console.Write("*");
                }
                Console.Write("*");
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int b = 0; b < 7; b++)
            {
                for (int c = 7; c > b; c--)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < b; a++)
                {
                    Console.Write("*");
                }
                for (int d = 0; d < b; d++)
                {
                    Console.Write("*");
                }
              Console.Write("*");
              Console.Write("\n");
            }
            for (int b = 0; b < 8; b++)
            {
                for (int c = 0; c < b; c++)
                {
                    Console.Write(" ");
                }
                for (int a = 7; a > b; a--)
                {
                    Console.Write("*");
                }
                for (int d = 8; d > b; d--)
                {
                    Console.Write("*");
                }
              
              Console.Write("\n");
            }

               Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Green;

            for (int b = 0; b < 5; b++)
            {
                for (int c = 35; c > b; c--)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < b; a++)
                {
                    Console.Write("*");
                }
                for (int d = 0; d < b; d++)
                {
                    Console.Write("*");
                }
                Console.Write("*");
                Console.Write("\n");
            }
            for (int b = 3; b < 10; b++)
            {
                for (int c = 35; c > b; c--)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < b; a++)
                {
                    Console.Write("*");
                }
                for (int d = 0; d < b; d++)
                {
                    Console.Write("*");
                }
                Console.Write("*");
                Console.Write("\n");
            }
            {
                for (int m = 6; m < 14; m++)
                {
                    for (int c = 35; c > m; c--)
                    {
                        Console.Write(" ");
                    }
                    for (int a = 0; a < m; a++)
                    {
                        Console.Write("*");
                    }
                    for (int d = 0; d < m; d++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("*");
                    Console.Write("\n");
                }
            }
            {
                for (int m = 9; m < 20; m++)
                {
                    for (int c = 35; c > m; c--)
                    {
                            Console.Write(" ");
                    }
                    for (int a = 0; a < m; a++)
                    {
                            Console.Write("*");
                    }
                    for (int d = 0; d < m; d++)
                    {
                            Console.Write("*");
                    }
                        Console.Write("*");
                        Console.Write("\n");
                }
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;

                for (int a = 0; a < 4; a++)
                {
                    for (int b = 0; b < 30; b++)
                    {
                        Console.Write(" ");
                    }
                    for (int b = 0; b < 10; b++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
