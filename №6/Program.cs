using System;

namespace number6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;
            Console.WriteLine("Введите четырехзначное число: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = a / 1000;
            c = (a - b * 1000) / 100;
            d = (a - b * 1000 - c * 100) / 10;
            e = (a - b * 1000 - c * 100 - d * 10);
            f = (b * c * d * e);
            Console.WriteLine($"Произведение: {f}");
        }
    }
}
