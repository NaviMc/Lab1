using System;

namespace number5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первого катета: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину второго катета: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) + (a + b);
            int d = (a * b) / 2;
            c = (int)c;
            Console.WriteLine($"Периметр: {c} , площадь: {d}");
        }
    }
}
