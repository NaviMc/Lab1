using System;

namespace number4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую переменную: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную: ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Первая переменная {a}, вторая переменная {b}");
        }
    }
}
