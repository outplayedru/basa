using System;

namespace GoToPara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Желание пить пиво (введите целое число): ");
            int beer;
                while (!int.TryParse(Console.ReadLine(), out beer))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            Console.WriteLine("Желание спать (введите целое число): ");
            int sleep;
                while (!int.TryParse(Console.ReadLine(), out sleep))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            Console.WriteLine("Желание получить баллы (введите целое число): ");
            int points;
                while (!int.TryParse(Console.ReadLine(), out points))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            Console.WriteLine("Шанс отлететь на сессию (введите целое число): ");
            int death;
                while (!int.TryParse(Console.ReadLine(), out death))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }

            if (beer + sleep >= points + death)
            {
                Console.WriteLine("Открываем пивко, наливаем в стакан. Или спим. ");
            }
            else
            {
                Console.WriteLine("Бегом на пару. ");
            }
        }
    }
}
