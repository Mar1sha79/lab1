using System;

namespace ConsoleAppl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Solution solver = new Solution();
            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine(" ЛАБОРАТОРНАЯ РАБОТА 1 ");
                Console.WriteLine("1 - Методы");
                Console.WriteLine("2 - Условия");
                Console.WriteLine("3 - Циклы");
                Console.WriteLine("4 - Массивы");
                Console.WriteLine("0 - Выход");
                Console.Write("Выберите блок заданий: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка ввода! Введите число.");
                    Console.ReadKey();
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Выход из программы");
                        break;
                    case 1:
                        RunTask1(solver);
                        break;
                    case 2:
                        RunTask2(solver);
                        break;
                    case 3:
                        RunTask3(solver);
                        break;
                    case 4:
                        RunTask4(solver);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор");
                        Console.ReadKey();
                        break;
                }

            } while (choice != 0);
        }

        private static int ReadInt(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Ошибка! Введите целое число.");
            }
        }

        private static char ReadChar(string prompt)
        {
            char value;
            while (true)
            {
                Console.Write(prompt);
                if (char.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Ошибка. Введите один символ.");
            }
        }

        private static string ReadString(string prompt)
        {
            string value;
            while (true)
            {
                Console.Write(prompt);
                value = Console.ReadLine();
                if (!string.IsNullOrEmpty(value))
                    return value;
                Console.WriteLine("Ошибка. Введите непустую строку.");
            }
        }

        private static int ReadPositiveInt(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value) && value > 0)
                    return value;
                Console.WriteLine("Ошибка. Введите положительное целое число.");
            }
        }

        private static int ReadNonNegativeInt(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value) && value >= 0)
                    return value;
                Console.WriteLine("Ошибка. Введите неотрицательное целое число.");
            }
        }

        private static void RunTask1(Solution solver)
        {
            Console.Clear();

            // Задача 2: Сумма знаков
            int num2 = ReadInt("Введите число для задачи 2: ");
            int result2 = solver.sumLastNums(num2);
            Console.WriteLine($"Сумма последних цифр: {result2}");

            // Задача 4: Есть ли позитив
            int num4 = ReadInt("Введите число для задачи 4: ");
            bool result4 = solver.isPositive(num4);
            Console.WriteLine($"Положительное число: {result4}");

            // Задача 6: Большая буква
            char char6 = ReadChar("Введите символ для задачи 6: ");
            bool result6 = solver.isUpperCase(char6);
            Console.WriteLine($"Заглавная буква: {result6}");

            // Задача 8: Делитель
            int a8 = ReadInt("Введите первое число для задачи 8: ");
            int b8 = ReadInt("Введите второе число для задачи 8: ");
            bool result8 = solver.isDivisor(a8, b8);
            Console.WriteLine($"Одно делит другое: {result8}");

            // Задача 10: Многократный вызов
            int numA = ReadInt("Введите первое число для задачи 10: ");
            int numB = ReadInt("Введите второе число для задачи 10: ");
            int result10 = solver.lastNumSum(numA, numB);
            Console.WriteLine($"Сумма последних цифр: {result10}");

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        private static void RunTask2(Solution solver)
        {
            Console.Clear();

            // Задача 2: Безопасное деление
            int x2 = ReadInt("Введите числитель(x) для задачи 2: ");
            int y2 = ReadInt("Введите знаменатель(y) для задачи 2: ");
            double result2 = solver.safeDiv(x2, y2);
            Console.WriteLine($"Результат деления: {result2}");

            // Задача 4: Строка сравнения
            int x4 = ReadInt("Введите первое число для задачи 4: ");
            int y4 = ReadInt("Введите второе число для задачи 4: ");
            string result4 = solver.makeDecision(x4, y4);
            Console.WriteLine($"Результат сравнения: {result4}");

            // Задача 6: Тройная сумма
            int x6 = ReadInt("Введите первое число для задачи 6: ");
            int y6 = ReadInt("Введите второе число для задачи 6: ");
            int z6 = ReadInt("Введите третье число для задачи 6: ");
            bool result6 = solver.sum3(x6, y6, z6);
            Console.WriteLine($"Два числа дают в сумме: {result6}");

            // Задача 8: Возраст
            int age8 = ReadInt("Введите возраст для задачи 8: ");
            string result8 = solver.age(age8);
            Console.WriteLine($"Результат: {result8}");

            // Задача 10: Вывод дней недели
            string day10 = ReadString("Введите день недели для задачи 10: ");
            Console.Write("Результат: ");
            solver.printDays(day10);

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        private static void RunTask3(Solution solver)
        {
            Console.Clear();

            // Задача 2: Числа наоборот
            int num2 = ReadInt("Введите число для задачи 2: ");
            string result2 = solver.reverseListNums(num2);
            Console.WriteLine($"Числа в обратном порядке: {result2}");

            // Задача 4: Степень числа
            int base4 = ReadInt("Введите основание для задачи 4: ");
            int exp4 = ReadInt("Введите показатель степени для задачи 4: ");
            int result4 = solver.pow(base4, exp4);
            Console.WriteLine($"Результат: {result4}");

            // Задача 6: Одинаковость
            int num6 = ReadInt("Введите число для задачи 6: ");
            bool result6 = solver.equalNum(num6);
            Console.WriteLine($"Все цифры одинаковы: {result6}");

            // Задача 8: Левый треугольник
            int size8 = ReadPositiveInt("Введите размер треугольника для задачи 8: ");
            Console.WriteLine("Левый треугольник:");
            solver.leftTriangle(size8);

            // Задача 10: Угадайка
            solver.guessGame();

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        private static void RunTask4(Solution solver)
        {
            Console.Clear();

            // Задача 2: Поиск последнего значения
            int size2 = ReadPositiveInt("Введите размер массива для задачи 2: ");
            int[] arr2 = ReadIntArray("Введите элементы массива:", size2);
            int search2 = ReadInt("Введите число для поиска: ");
            int result2 = solver.findLast(arr2, search2);
            Console.WriteLine($"Индекс последнего вхождения: {result2}");

            // Задача 4: Добавление в массив
            int size4 = ReadNonNegativeInt("Введите размер массива для задачи 4: ");
            int[] arr4 = ReadIntArray("Введите элементы массива:", size4);
            int insert4 = ReadInt("Введите число для вставки: ");

            int pos4;
            while (true)
            {
                pos4 = ReadInt("Введите позицию для вставки: ");
                if (pos4 >= 0 && pos4 <= size4)
                    break;
                Console.WriteLine($"Ошибка! Позиция должна быть от 0 до {size4}.");
            }

            int[] result4 = solver.add(arr4, insert4, pos4);
            Console.Write("Результат: ");
            PrintArray(result4);

            // Задача 6: Реверс
            int size6 = ReadPositiveInt("Введите размер массива для задачи 6: ");
            int[] arr6 = ReadIntArray("Введите элементы массива:", size6);
            solver.reverse(arr6);
            Console.Write("Массив после реверса: ");
            PrintArray(arr6);

            // Задача 8: Объединение
            int size8a = ReadNonNegativeInt("Введите размер первого массива для задачи 8: ");
            int[] arr8a = ReadIntArray("Введите элементы первого массива:", size8a);
            int size8b = ReadNonNegativeInt("Введите размер второго массива для задачи 8: ");
            int[] arr8b = ReadIntArray("Введите элементы второго массива:", size8b);
            int[] result8 = solver.concat(arr8a, arr8b);
            Console.Write("Объединенный массив: ");
            PrintArray(result8);

            // Задача 10: Удалить негатив
            int size10 = ReadPositiveInt("Введите размер массива для задачи 10: ");
            int[] arr10 = ReadIntArray("Введите элементы массива:", size10);
            int[] result10 = solver.deleteNegative(arr10);
            Console.Write("Массив без отрицательных: ");
            PrintArray(result10);

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        private static int[] ReadIntArray(string prompt, int length)
        {
            int[] array = new int[length];
            Console.WriteLine(prompt);
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }
            }
            return array;
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}