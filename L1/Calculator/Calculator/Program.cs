using System;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 2, operand2 = 0;
            Console.Write("Выберите знак арифметической операции: +, -, *, /.");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                {
                    Console.WriteLine(operand1 + operand2);
                    break;
                }
                case "-":
                {
                    Console.WriteLine(operand1 - operand2);
                    break;
                }
                case "*":
                {
                    Console.WriteLine(operand1 * operand2);
                    break;
                }
                case "/":
                    if (operand2 > 0)
                    {
                        Console.WriteLine(operand1 / operand2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }  break;
            }

            Console.ReadKey();
        }
    }
}