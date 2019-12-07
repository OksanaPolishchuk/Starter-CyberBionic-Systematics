using System;
namespace Lesson8Ex2
{
    class Program
    {
        static int Div(int a, int term)
        {
            if (term == 0)
            {
                return a;
            }
            else
            {
                 return a / term;
            }
        }
        static int Difference(int a, int b, int term)
        {
            return a - b;
        }
        static void Recursion(int a, int b, int term)
        {
                Console.WriteLine("Amount of your loan is ${0}", a);
                Console.WriteLine("Loan term is {0} ", term + " months");

                int payment1 = Div(a, term);

                Console.WriteLine("Your monthly payment is ${0}", payment1);
                Console.WriteLine("  ");

                bool isClosed = false;

                do
                {
                    if (term == 0)
                    {
                    Console.WriteLine("The lorn term is due. Please make the full payment! ");
                    }
                    Console.WriteLine("Would you like to make a payment? Please enter your choice: yes/no");
                    string x = Console.ReadLine();

                    switch (x)
                    {
                        case "yes":
                        {
                            do
                            {
                                if (term >= 0)
                                {
                                    Console.WriteLine("How much are you going to pay?");
                                    string @payment = Console.ReadLine();
                                    b = 0;
                                    int.TryParse(@payment, out b);
                                }
                                if (b <= 0)
                                {
                                    Console.WriteLine("Error. Please try again");
                                    term = 0;
                                    break;
                                }
                                int balance = Difference(a, b,term);
                                if (b < balance && term == 0)
                                {
                                    Console.WriteLine("Error. Please try again");
                                    term = 0;
                                    break;
                                }
                                if (balance < b)
                                {
                                    int overpay = Difference(b, Div(a, term),term);
                                    Console.WriteLine("You have a monthly overpay ${0}", overpay);
                                }
                                if (balance < 0)
                                {
                                    int overpay = Difference(b, a, term);
                                    Console.WriteLine("You have total loan overpay ${0}", overpay);
                                }
                                if (payment1 > b)
                                {
                                    int arrears = Difference(b, payment1,term);
                                    Console.WriteLine("Your monthly payment is lower than expected: ${0}", arrears);
                                }
                                if (balance <= 0)
                                {
                                    Console.WriteLine("  ");
                                    Console.WriteLine("Congratulations! Loan is closed.");
                                    Console.WriteLine("  ");
                                    isClosed = true;
                                    term = 0;
                                    break;
                                }
                                else if (b != 0 && b > 0)
                                {
                                    Console.WriteLine("  ");
                                    Console.WriteLine("Loan balance ${0}", balance);

                                    term--;

                                    if (term >= 0)
                                    {
                                        a = Difference(a, b,term);
                                    }

                                    balance = Div(balance, term);
                                    Console.WriteLine("Your next mandatory payment is ${0}", balance);
                                }
                            } while (term > 0 );
                         break;
                        }
                        case "no":
                        {
                            Console.WriteLine("Have a nice day.");
                            term = 1;
                        }
                     break;
                    }
                    if (term > 0)
                    {
                        Recursion(a, b, term);
                    }
                } while (term >= 0 && !isClosed);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сredit amount?");
            Console.WriteLine("  ");
            string c = Console.ReadLine();
            int a = 0;
            int.TryParse(c, out a);

            if (a <= 0)
            {
                Console.WriteLine("Error. Please try again");
            }
            else if (a > 0)
            {
                Console.WriteLine("Please enter loan term. (number of months)");
                string z = Console.ReadLine();
                int term = 0;
                int.TryParse(z, out term);

                if (term <= 0)
                {
                    Console.WriteLine("Error. Please try again");
                }
                else
                {
                    Console.WriteLine("How much are you going to pay?");

                    string @payment = Console.ReadLine();
                    int b = 0;
                    int.TryParse(@payment, out b);
                    Recursion(a, b, term);
                }
            }Console.ReadKey();
        }
    }
}
