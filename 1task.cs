// импортируем пространства имен, содержащие необходимые классы и методы
using System;
using System.Linq;

// создаем пространство имен "Library"
namespace Library
{
    // создаем класс "Zadania"
    public class Zadania
    {
        // создаем метод "ZadanieOne"
        public static void ZadanieOne()
        {
            // выводим сообщение на экран и запрашиваем ввод числа N
            Console.Write("Введите число N: ");
            int n;
            // проверяем корректность ввода
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Некорректный ввод. Введите положительное число N: ");
            }
            // формируем строку, содержащую числа от 1 до N, разделенные запятыми
            string result = string.Join(", ", Enumerable.Range(1, n));
            // выводим результат на экран
            Console.WriteLine(result);
        }
        // создаем метод "ZadanieTwo"
        public static void ZadanieTwo()
        {
            // выводим сообщение на экран и запрашиваем ввод нечетного числа N
            Console.Write("Введите нечетное число N: ");
            int n;
            // проверяем корректность ввода
            while (!int.TryParse(Console.ReadLine(), out n) || n % 2 == 0 || n < 3)
            {
                Console.Write("Некорректный ввод. Введите нечетное число N, большее 3: ");
            }

            // определяем центральную позицию в матрице
            int center = n / 2;

            // создаем двойной цикл, который будет перебирать все элементы матрицы
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    // если текущий элемент находится в центре матрицы, то выводим пробел
                    if (row == center && col == center)
                    {
                        Console.Write(" ");
                    }
                    // иначе выводим символ #
                    else
                    {
                        Console.Write("#");
                    }
                }
                // переходим на следующую строку матрицы
                Console.WriteLine();
            }
        }

        // создаем точку входа в программу
        static void Main(string[] args)
        {
            // вызываем метод ZadanieTwo из класса Zadania
            Zadania.ZadanieTwo();

            // вызываем метод ZadanieOne из класса Zadania
            Zadania.ZadanieOne();

            // ждем, пока пользователь нажмет любую клавишу
            Console.ReadLine();
        }
    }

}
