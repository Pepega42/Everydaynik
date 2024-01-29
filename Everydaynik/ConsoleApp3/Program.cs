namespace ConsoleApp3
{
    internal class Program
    {
        static DateTime date = new DateTime(2024, 01, 15);
        static int date1 = 1;
        static int position = 1;
        static void Main(string[] args)
        {
            Menu();
            Strelki();
            Desc();
        }
        static void Menu()
        {
            if (date1 == 1)
            {
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
                Console.WriteLine("  1. Прогулять пару");
                Console.WriteLine("  2. Поесть пиццы");
            }
            else if (date1 == 2)
            {
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
                Console.WriteLine("  1. Ненавижу просыпаться");
                Console.WriteLine("  2. Долго ехать домой");
            }
            else if (date1 == 3)
            {
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
                Console.WriteLine("  1. Проснуться");
                Console.WriteLine("  2. Сидеть заниматься важными делами");
            }
        }
        static void Strelki()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && position > 1)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == 3)
                    {
                        position = 2;
                    }
                }
                else if ( key.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(date.ToShortDateString());
                    date1--;
                    Menu();
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(+1);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(date.ToShortDateString());
                    date1++;
                    Menu();
                }


                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }
        }
        static void Desc()
        {
            if (position == 1 && date1 == 1)
            {
                Console.Clear();
                Console.WriteLine("Прогулять пару");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Пары прогуливаются просто.");
                Console.WriteLine(date.ToShortDateString());
            }
            else if (position == 2 && date1 == 1)
            {
                Console.Clear();
                Console.WriteLine("Поесть пиццы");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Есть пиццу с крабами, что тут ещё сказать.");
                Console.WriteLine(date.ToShortDateString());
            }
            else if (position == 1 && date1 == 2)
            {
                Console.Clear();
                Console.WriteLine("Ненавижу просыпаться");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Просыпаться за 2 часа до начала пар, чтобы успеть.");
                Console.WriteLine(date.ToShortDateString());
            }
            else if (position == 2 && date1 == 2)
            {
                Console.Clear();
                Console.WriteLine("Долго ехать домой");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Ехать домой 2 часа и потом страдать.");
                Console.WriteLine(date.ToShortDateString());
            }
            else if (position == 1 && date1 == 3)
            {
                Console.Clear();
                Console.WriteLine("Проснуться");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Проснуться(опцонально).");
                Console.WriteLine(date.ToShortDateString());
            }
            else if (position == 2 && date1 == 1)
            {
                Console.Clear();
                Console.WriteLine("Сидеть заниматься важными делами");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Естественно играть и писать практические.");
                Console.WriteLine(date.ToShortDateString());
            }
        }
    }
}