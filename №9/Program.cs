using System;

namespace number9
{
    class Program
    {
        static void Main(string[] args)
        {
            float a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, x, y, z, ay, ad, az, ax;
            Console.Write("Дана система уравнений типа: a1x + b1y + с1z = d1");
            Console.Write("                                                                                                    a2x + b2y + с2z = d2");
            Console.WriteLine("                                                                                                    a3x + b3y + с3z = d3");
            Console.WriteLine("Введите a1: ");
            a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите b1: ");
            b1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите c1: "); 
            c1 = float.Parse(Console.ReadLine());
            ax = a1 * b1 / c1;
            Console.WriteLine("Введите d1, которое не равно 0: ");
            d1 = float.Parse(Console.ReadLine());
            if (d1 != 0) {
            Console.WriteLine("Введите a2: ");
            a2 = float.Parse(Console.ReadLine());
            ay = a2 * a1 / a1;
            az = c1 * a2 / a1;
            ad = d1 * a2 / a1;
            a2 = a2 - ax;
            Console.WriteLine("Введите b2: ");
            b2 = float.Parse(Console.ReadLine());
            b2 = b2 - ay;
            Console.WriteLine("Введите c2: ");
            c2 = float.Parse(Console.ReadLine());
            c2 = c2 - az;
            Console.WriteLine("Введите d2, которое не равно 0: ");
            d2 = float.Parse(Console.ReadLine());
            if (d2 != 0) { 
            d2 = d2 - ad;
            Console.WriteLine("Введите a3: ");
            a3 = float.Parse(Console.ReadLine());
            ax = a1 * a3 / a1;
            ay = b1 * a3 / a1;
            az = c1 * a3 / a1;
            ad = d1 * a3 / a1;
            a3 = a1 - ax;
            Console.WriteLine("Введите b3: ");
            b3 = float.Parse(Console.ReadLine());
            b3 = b3 - ay;
            Console.WriteLine("Введите c3: ");
            c3 = float.Parse(Console.ReadLine());
            c3 = c3 - az;
            Console.WriteLine("Введите d3, которое не равно 0: ");
            d3 = float.Parse(Console.ReadLine());
            if (d3 != 0) { 
            d3 = d3 - ad;
            z = d3 / c3;
            y = (c2 - b2 * z) / b2;
            x = (d1 - c1 * z - b1 * y) / a1;
            Console.WriteLine($" Ответ:x={x};y={y};z={z}");
            }
            else
                Console.WriteLine("Ошибка: d3 = 0");
                
            }
            else
                Console.WriteLine("Ошибка: d2 = 0");
                    
            }
            else
                Console.WriteLine("Ошибка: d1 = 0");
        }
    }
}
