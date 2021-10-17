using System;

namespace number1 
    {

    class Program
    {
        static void Main(string[] args)
        {
        float a, b;
        Console.WriteLine("Введите данные: ");
        a = float.Parse(Console.ReadLine());
        int c;
        c = (int)a;
        b = (a - c) * 10;
        b = (int)b;
        Console.WriteLine($"Ответ: {b}");
        }
    }
}
