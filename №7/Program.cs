using System;

namespace number7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = Convert.ToString(a);
            char[] c = b.ToCharArray();
            Array.Reverse(c);
            string d = new string(c);
            Console.WriteLine($"Ответ: {d}");


        }
    }
}
