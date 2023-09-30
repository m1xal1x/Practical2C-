using System.ComponentModel.Design;
namespace Игры
{
    class programs
    {
        static void Main()
        {
            int menu;
            do
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Игра 'Угадай число'.");
                Console.WriteLine("2. Таблица умножения.");
                Console.WriteLine("3. Вывод делителей числа.");
                Console.WriteLine("4. Выход из программы.");
                int.TryParse(Console.ReadLine(), out menu);
                switch (menu)
                {
                    case 1:
                        Ugadaichislo();
                        break;
                    case 2:
                        TablicaUmnozhenia();
                        break;
                    case 3:
                        DeliteliChisla();
                        break;
                }
            } while (menu != 4);

        }
        static void Ugadaichislo()
        {
            int a;
            Random r = new Random();
            int random = r.Next(1, 100);
            do
            {
                Console.WriteLine("Введите число: ");
                int.TryParse(Console.ReadLine(), out a);
                if (a == random)
                {
                    Console.WriteLine("Вы угадали число");
                }
                else if (a < random)
                {
                    Console.WriteLine("Необходимо взять число больше");
                }
                else if (a > random)
                {
                    Console.WriteLine("Необходимо взять число меньше");
                }
            } while (a != random);
        }
        static void TablicaUmnozhenia()
        {
            int[,] tablica = new int[10, 10];
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    tablica[i - 1, j - 1] = i * j;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void DeliteliChisla()
        {
            int a, ost, menu;
            do
            {
                Console.Write("Введите число: ");
                int.TryParse(Console.ReadLine(), out a);
                Console.Write("Делители: ");
                for (int i = 1; i <= a; i++)
                {
                    ost = a % i;
                    if (ost == 0)
                        Console.Write(i + " ");
                }
                Console.WriteLine("\n Хотите узнать делители еще одного числа?" + "\n 1. Да." + "\n 2. Нет.");
                int.TryParse(Console.ReadLine(), out menu);
            } while (menu != 2);
        }
    }       
}