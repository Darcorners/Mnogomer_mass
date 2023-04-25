using System;

namespace Mnogomer_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание трехмерного массива
        int[,,] array3D = new int[3, 3, 3] {
        {{1,2,3}, {4,5,6}, {7,8,9}},
        {{10,11,12}, {13,14,15}, {16,17,18}},
        {{19,20,21}, {22,23,24}, {25,26,27}}
        };

            // Установка начальных значений
            int x = 0; // текущий слой (по оси x)
            int y = 0; // текущая строка (по оси y)
            int z = 0; // текущий столбец (по оси z)

            // Вывод текущего элемента массива
            Console.WriteLine($"Текущий элемент: {array3D[x, y, z]}");

            // Ожидание ввода клавиши
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);

                // Обработка клавиши
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        // Перемещение курсора влево
                        if (x > 0)
                        { // проверяем, не вышли ли мы за границы массива
                            x--; // перемещаемся на предыдущий слой
                            Console.WriteLine($"Текущий элемент: {array3D[x, y, z]}");
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        // Перемещение курсора вправо
                        if (x < array3D.GetLength(0) - 1)
                        { // проверяем, не вышли ли мы за границы массива
                            x++; // перемещаемся на следующий слой
                            Console.WriteLine($"Текущий элемент: {array3D[x, y, z]}");
                        }
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Escape); // выходим из цикла при нажатии клавиши "Escape"
        }
    }
}
