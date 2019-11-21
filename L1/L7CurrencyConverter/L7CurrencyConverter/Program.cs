using System;
namespace L7CurrencyConverter
{
    class Program
    {
        static double Mul(double x, double w)
        {
            return x * w;
        }
        static double Div(double x, double w)
        {
            return x / w;
        }
        static double Calculate(double x, double usd, double w)
        {
            return x * usd / w;
        }
    static void Main(string[] args)
    {
            Console.WriteLine("Какую валюту хотите обменять? UAH, USD, EUR");
            string a = Console.ReadLine();

            Console.WriteLine("Введите сумму");
            string b = Console.ReadLine();
            double x = Convert.ToDouble(b);

            Console.WriteLine("На какую валюту желаете осуществить обмен?  UAH, USD, EUR");
            string c = Console.ReadLine();

            Console.WriteLine("Укажите желаемый курс.");
            string f = Console.ReadLine();
            double w = Convert.ToDouble(f);

            //double usd = 0.9034; Лучше через индекс, но в условиях пользователь вводит курс. 
            //double eur = 1.0926;
            double usd = 24.10;
            double eur = 26.50;
            double sum = 0;

            switch (a)
            {
                case "uah":
                {
                    switch (c)
                    {
                        case "usd":
                        {
                            sum = Div(x, w);
                            Console.WriteLine("{0} / {1} = {2}", x, w, sum, "usd");
                            break;
                        }
                        case "eur":
                        {
                            sum = Div(x, w);
                            Console.WriteLine("{0} / {1} = {2}", x, w, sum, "eur");
                            break;
                        }
                        case "uah":
                        {
                            Console.WriteLine("Неправильный ввод. Повторите попытку.");
                        }   break;
                    }
                }break;

                case "usd":
                {
                    switch (c)
                    {
                        case "eur":
                        {
                            sum = Calculate(x, usd, w);
                            Console.WriteLine("{0} * {1} / {2} = {3}", x, usd,w, sum, "eur");
                            break;
                        }
                        case "uah":
                        {
                            sum = Mul(x, w);
                            Console.WriteLine("{0} * {1} = {2}", x, w, sum, "uah");
                            break;
                        }
                        case "usd":
                        {
                            Console.WriteLine("Неправильный ввод. Повторите попытку.");
                            break;
                        }
                    }
                } break;

                case "eur":
                {
                    switch (c)
                    {
                        case "usd":
                        {
                            sum = Calculate(x, usd,w);
                            Console.WriteLine("{0} * {1} / {2} = {3}", x, usd, w, sum, "eur");
                                    break;
                        }
                        case "uah":
                        {
                           sum = Mul(x, w);
                            Console.WriteLine("{0} * {1} = {2}", x, w, sum,"uah");
                            break;
                        }
                        case "eur":
                        {
                            Console.WriteLine("Неправильный ввод. Повторите попытку.");
                            break;
                        }
                    }
                }break;
            }
            Console.ReadKey();
        }
    }
}








