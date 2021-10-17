using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Формула номер один:");
            double x, c, m, z;
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("m = ");
            m = Convert.ToDouble(Console.ReadLine());
            z = Math.Sin(x) / Math.Sqrt(Math.Pow(m, 2) + Math.Pow(Math.Sin(x), 2)) - c * m * Math.Log(m * x);
            Console.Write($"z = {z}");

            
            Console.WriteLine("Формула номер два: ");
            double a, b, s, e = 2.7;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            s = Math.Pow(e, -a * x) * Math.Sqrt(x + 1) + Math.Pow(e, -b * x) * Math.Sqrt(x + 1.5);
            Console.Write($"s = {s}");
        }
    }
}
