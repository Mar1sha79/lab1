using System;

namespace ConsoleAppl
{
    public class Solution
    {

        // Задача 2: Сумма знаков
        public int sumLastNums(int x)
        {
            if (x < 10) return x;
            int lastDigit = Math.Abs(x) % 10;
            int prevDigit = (Math.Abs(x) / 10) % 10;
            return lastDigit + prevDigit;
        }

        // Задача 4: Есть ли позитив
        public bool isPositive(int x)
        {
            return x > 0;
        }

        // Задача 6: Большая буква
        public bool isUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        // Задача 8: Делитель
        public bool isDivisor(int a, int b)
        {
            if (a == 0 || b == 0)
                return false;

            return (b % a == 0) || (a % b == 0);
        }

        // Задача 10: Многократный вызов
        public int lastNumSum(int a, int b)
        {
            return (a % 10) + (b % 10);
        }


        // Задача 2: Безопасное деление
        public double safeDiv(int x, int y)
        {
            if (y == 0) return 0;
            return (double)x / y;
        }

        // Задача 4: Строка сравнения
        public string makeDecision(int x, int y)
        {
            if (x > y) return $"{x} > {y}";
            if (x < y) return $"{x} < {y}";
            return $"{x} == {y}";
        }

        // Задача 6: Тройная сумма
        public bool sum3(int x, int y, int z)
        {
            return (x + y == z)|(x + z == y)|(y + z == x);
        }

        // Задача 8: Возраст
        public string age(int x)
        {
            int lastDigit = x % 10;
            int lastTwoDigits = x % 100;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
                return $"{x} лет";
            if (lastDigit == 1)
                return $"{x} год";
            if (lastDigit >= 2 && lastDigit <= 4)
                return $"{x} года";

            return $"{x} лет";
        }

        // Задача 10: Вывод дней недели
        public void printDays(string x)
        {
            int dayNumber;
            switch (x.ToLower())
            {
                case "понедельник": dayNumber = 1; break;
                case "вторник": dayNumber = 2; break;
                case "среда": dayNumber = 3; break;
                case "четверг": dayNumber = 4; break;
                case "пятница": dayNumber = 5; break;
                case "суббота": dayNumber = 6; break;
                case "воскресенье": dayNumber = 7; break;
                default:
                    Console.WriteLine("это не день недели");
                    return;
            }

            string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

            for (int i = dayNumber - 1; i < days.Length; i++)
            {
                Console.Write(days[i] + " ");
            }
            Console.WriteLine();
        }
        
        // Задача 2: Числа наоборот
        public string reverseListNums(int x)
        {
            string result = "";
            for (int i = x; i >= 0; i--)
            {
                result += i + " ";
            }
            return result.Trim();
        }

        // Задача 4: Степень числа
        public int pow(int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        // Задача 6: Одинаковость
        public bool equalNum(int x)
        {
            if (x < 10) return true;

            int lastDigit = Math.Abs(x) % 10;
            int temp = Math.Abs(x) / 10;

            while (temp > 0)
            {
                int currentDigit = temp % 10;
                if (currentDigit != lastDigit)
                    return false;
                temp /= 10;
            }
            return true;
        }

        // Задача 8: Левый треугольник
        public void leftTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Задача 10: Угадайка
        public void guessGame()
        {
            Random random = new Random();
            int secretNumber = random.Next(0, 10);
            int attempts = 0;
            int guess;

            Console.WriteLine("Угадайте число от 0 до 9!");

            do
            {
                Console.Write("Введите число: ");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Ошибка! Введите число от 0 до 9: ");
                }

                attempts++;

                if (guess == secretNumber)
                {
                    Console.WriteLine($"Вы угадали! Потребовалось попыток: {attempts}");
                }
                else
                {
                    Console.WriteLine("Не угадали! Попробуйте еще раз.");
                }
            } while (guess != secretNumber);
        }


        // Задача 2: Поиск последнего значения
        public int findLast(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
        
        // Задача 4: Добавление в массив
        public int[] add(int[] arr, int x, int pos)
        {
            if (pos < 0 || pos > arr.Length)
                return arr;

            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < pos; i++)
                newArr[i] = arr[i];

            newArr[pos] = x;

            for (int i = pos; i < arr.Length; i++)
                newArr[i + 1] = arr[i];

            return newArr;
        }

        // Задача 6: Реверс
        public void reverse(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        // Задача 8: Объединение
        public int[] concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
                result[i] = arr1[i];

            for (int i = 0; i < arr2.Length; i++)
                result[arr1.Length + i] = arr2[i];

            return result;
        }

        // Задача 10: Удалить негатив
        public int[] deleteNegative(int[] arr)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num >= 0) count++;
            }

            int[] result = new int[count];
            int index = 0;

            foreach (int num in arr)
            {
                if (num >= 0)
                {
                    result[index] = num;
                    index++;
                }
            }

            return result;
        }
    }
}
