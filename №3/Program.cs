using System;

namespace number3
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s, z, x;
            double a, b;
            Console.WriteLine("Укажите количество прошедших часов: ");
            h = Convert.ToInt32(Console.ReadLine());
            z = (h * 30);
            Console.WriteLine("Укажите количество прошедших минут: ");
            m = Convert.ToInt32(Console.ReadLine());
            x = (m * 2);
            Console.WriteLine("Укажите количество прошедших секунд: ");
            s = Convert.ToInt32(Console.ReadLine());
            a = (s * 0.03);  
            b = (z + x + a);
            Console.WriteLine($"Стрелка прошла {b} градусов");  
        }
    }
}
