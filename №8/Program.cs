using System;

namespace number8
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, x2, x3, x4, y;
            Console.WriteLine("Введите x: ");
            x = float.Parse(Console.ReadLine());
            x4 = x;
            x3 = x;
            x2 = x;
            Math.Pow(x2, 2);
            Math.Pow(x3, 3);
            Math.Pow(x4, 4);
            y = (((3 * x4 - 5) * x3 + 2) * x2 - 1) * x + 7;
            Console.WriteLine($"Ответ: {y}");
        }
    }
}
