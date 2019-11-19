
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

            // ялинка
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

            //----------------------------------------------------------------
            //листва

            //може бути довільним числом
            const int NUMBER_OF_SECTIONS = 3;

            //number of lines in the 1st section
            //може бути довільним числом
            const int BASE_NUMBER_OF_LINES = 5;

            //різниця в ширині між останньою лінією першої секції
            //і першої лінії другої секціїї
            //може бути довільним числом
            const int BASE_NEXT_SECTION_SHORTENING = 1;

            //ідея - обчислити ширину листви біля стовбуру = максимальну ширину листви
            //для того щоб далі знаючи ширину довільної лінії листви
            //обчислювати відступ для цієї лінії
            //максимальна ширина обчилюється через задані кількість секцій
            //і кіль
            int sumOfWidthShortenings = 0;
            int numberOfLines = 0;
            for (int i = 0; i < NUMBER_OF_SECTIONS; ++i)
            {
                numberOfLines += BASE_NUMBER_OF_LINES + 2 * NUMBER_OF_SECTIONS;

                //BASE_NEXT_SECTION_SHORTENING*4 - сумарна різниця між 
                // ????
                sumOfWidthShortenings += (BASE_NEXT_SECTION_SHORTENING * 2 + 2) * NUMBER_OF_SECTIONS;
            }
            int foliageWidth = numberOfLines * 2 - 1 - sumOfWidthShortenings;
            //????
            int firstLineElongation = (BASE_NUMBER_OF_LINES - 1) * 2 - 2 * BASE_NEXT_SECTION_SHORTENING;

            for (int sectionIndex = 0; sectionIndex < NUMBER_OF_SECTIONS; ++sectionIndex)
            {
                for (int lineIndex = 0; lineIndex < BASE_NUMBER_OF_LINES + 2 * sectionIndex; ++lineIndex)
                {
                    int lineLength = lineIndex * 2 + 1 + sectionIndex * firstLineElongation;
                    for (int i = 0; i < (foliageWidth - lineLength) / 2; ++i)
                    {
                        Console.Write(' ');
                    }
                    for (int i = 0; i < lineLength; ++i)
                    {
                        Console.Write("*");
                    }
                    Console.Write('\n');
                }
            }

            //стовбур

            const double TRUNK_FOLIAGE_RATIO = 0.25; //може бути довільним числом
            const double TRUNK_HEIGHT_WIDTH_RATIO = 0.5; //може бути довільним числом

            int trunkWidth = Convert.ToInt32(foliageWidth * TRUNK_FOLIAGE_RATIO);
            int trunkHeight = Convert.ToInt32(trunkWidth * TRUNK_HEIGHT_WIDTH_RATIO);
            int trunkIndentation = (foliageWidth - trunkWidth) / 2;
            for (int i = 0; i < trunkHeight; ++i)
            {
                for (int j = 0; j < trunkIndentation; ++j)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < trunkWidth; ++j)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }
        }
    }
}
