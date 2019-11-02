using System;
namespace Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Русcко - английский переводчик. Введите любое слово на русском языке из темы о погоде.");
            string word = Console.ReadLine();
            switch (word)
            {
                case "погода":
                {
                    Console.WriteLine("weather");
                    break;
                }
                case "солнце":
                {
                    Console.WriteLine("sun");
                    break;
                }
                case "солнечно":
                {
                    Console.WriteLine("sunny");
                    break;
                }
                case "тепло":
                {
                    Console.WriteLine("warm");
                    break;
                }
                case "жарко":
                {
                    Console.WriteLine("hot");
                    break;
                }
                case "пасмурно":
                {
                    Console.WriteLine("Mainly cloudy");
                    break;
                }
                case "облачно":
                {
                    Console.WriteLine("cloudy");
                    break;
                }
                case "дождь":
                {
                    Console.WriteLine("rain");
                    break;
                }
                case "дождливо":
                {
                    Console.WriteLine("it is raining");
                    break;
                }
                case "холодно":
                {
                    Console.WriteLine("coldly");
                    break;
                }
                case "снег":
                {
                    Console.WriteLine("snow");
                    break;
                }
                case "снегопад":
                {
                    Console.WriteLine("snowfall");
                    break;
                }
                case "ветер":
                {
                    Console.WriteLine("wind");
                    break;
                }
                case "ветрено":
                {
                    Console.WriteLine("windy");
                    break;
                }
                default:
                {
                    Console.Write("Извините, в словаре отсутствует слово ");
                    Console.WriteLine(word);
                    break;
                }
            }
            Console.ReadKey();
        } 
    }
}
