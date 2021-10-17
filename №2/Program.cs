using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время в секундах: ");
            int t = Convert.ToInt32(Console.ReadLine());
            int h = t / 3600;
            int m = ((t - (h * 3600)) / 60);
            int s = (t - (h * 3600) - (m * 60));
            Console.WriteLine($"Прошло {h} часов, {m} минут, {s} секунд");
        }
    }
}
