using System;

namespace Lesson5Ex4
{
    class Program
    {
        static void Main(string[] args)
        { /*  Задание 4
                  Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
                  Напишите программу расчета начисления премий сотрудникам. Премии рассчитываются согласно выслуге лет.
                  Если выслуга до 5 лет, премия составляет 10 % от заработной платы.  
                  Если выслуга от 5 лет(включительно) до 10 лет, премия составляет 15 % от заработной платы.  
                  Если выслуга от 10 лет(включительно) до 15 лет, премия составляет 25 % от заработной платы.  
                  Если выслуга от 15 лет(включительно) до 20 лет, премия составляет 35 % от заработной платы.  
                  Если выслуга от 20 лет(включительно) до 25 лет, премия составляет 45 % от заработной платы. 
                  Если выслуга от 25 лет(включительно) и более, премия составляет 50 % от заработной платы.  
                  Результаты расчета, выведите на экран. */

            double salary = 157;
            double bonus = 0;

            Console.WriteLine("Премии рассчитываются согласно выслуге лет. Укажите выслугу.");

            string z = Console.ReadLine();
            double x = Convert.ToInt32(z);

            if (0 < x && x < 5) 
            {
                bonus = ((salary / 100) * 10);
                Console.WriteLine(bonus);
            } 
            if (4 < x && x < 10)
            {
                bonus = ((salary / 100) * 15);
                Console.WriteLine(bonus);
            }
            if (9 < x && x < 15)
            {
                bonus = ((salary / 100) * 25);
                Console.WriteLine(bonus);
            } 
            if (14 < x && x < 20)
            {
                bonus = ((salary / 100) * 35);
                Console.WriteLine(bonus);
            } 
            if (19 < x && x < 25)
            {
                bonus = ((salary / 100) * 45);
                Console.WriteLine(bonus);
            } 
            if (24 < x) 
            {
                bonus = ((salary / 100) * 50); 
                Console.WriteLine(bonus);
            }
            Console.ReadKey();
        }
    }
}
