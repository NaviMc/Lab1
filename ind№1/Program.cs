using System;
using System.Collections;

namespace ind1
{
    public class ind1
    {

        public struct variant3
        {
            public String Фильм;
            public String Режиссер;
            public int Год_выпуска;
            public String Тип;

            public variant3(string Фильм, String Режиссер, int Год_выпуска, string Тип)
            {
                this.Фильм = Фильм;
                this.Режиссер = Режиссер;
                this.Год_выпуска = Год_выпуска;
                this.Тип = Тип;

            }

            public void Разметка()
            {
                Console.WriteLine($"|{this.Фильм,-24}|{this.Режиссер,-20}|{this.Год_выпуска,-20}|{this.Тип,-18}|");

            }
        }

        private static void Main()
        {
            ArrayList list = new();


            bool banner = true;
            while (banner)
            {
                Console.WriteLine("Фильм:");
                string Фильм = Console.ReadLine();

                Console.WriteLine("Режиссер");
                string Режиссер = Console.ReadLine();

                Console.WriteLine("Год выпуска");
                int Год_выпуска = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Тип");
                string Тип = (Console.ReadLine());
                variant3 value = new(Фильм, Режиссер, Год_выпуска, Тип);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Продолжить?\nда - перейти на следующую строку\nнет - показать таблицу");
                    string entrance = Console.ReadLine();
                    if (entrance == "да" || entrance == "нет")
                    {
                        if (entrance == "нет")
                        {
                            banner = false;
                            break;
                        }
                        break;
                    }
                    else Console.WriteLine("Ошибка. Данные введены некоректно");
                }

            }
            Console.WriteLine(new String('-', 87));
            Console.WriteLine($"{"|Кинопродукция",-86}|");
            Console.WriteLine(new String('-', 87));
            Console.WriteLine($"{"|Фильм",-25}|{"Режиссер ",-20}|{"Год выпуска ",-20}|{"Тип",-18}|");
            Console.WriteLine(new String('-', 87));
            foreach (variant3 item in list)
            {
                item.Разметка();
                Console.WriteLine(new String('-', 87));
            }
            Console.WriteLine($"{"|Перечисляемый тип: Д - драма, K – комедия, M - мелодрама, Б - боевик, A - мультфильм,",-86}|");
            Console.WriteLine(new String('-', 87));
        }

    }
}