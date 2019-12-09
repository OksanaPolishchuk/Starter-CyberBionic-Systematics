using System;
namespace Lesson8Ex3
{
    class Program
    {
        static int Fact(int customers)
        {
            if (customers == 0)
            {
                return 0;
            }
            else if (customers == 1)
            {
                return 1;
            }
            return customers * Fact(customers - 1);
        }
        static void Main(string[] args)
        {
            //   N! = N * (N-1)
            // It is not recommended to use recursion to calculate the factorial,  
            // since it is highly likely to get stack overflow exception
            // and methods' calls consume  more resources.

            Console.WriteLine("How many customers?");
            string a = Console.ReadLine();
            int customers = 0;
            int.TryParse(a, out customers);

            bool isClosed = false;

            if (customers <= 0)
            {
                Console.WriteLine("Error. Please check the number of customers and try again.");
                isClosed = true;
            }
            else
            {
                Console.WriteLine("How many cars?");
                string b = Console.ReadLine();
                int cars = 0;
                int.TryParse(b, out cars);

                if (cars <= 0)
                {
                    Console.WriteLine("Error. Please check the number of cars and try again.");
                    isClosed = true;
                }

                int deliveryOptions = cars * Fact(customers);
                Console.WriteLine("There are {0}", deliveryOptions + " delivery options.");
            }
            Console.ReadKey();
        }
    }
}
