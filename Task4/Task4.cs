using System;
using System.Text;

namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            for (int j = 0; j < height; j++)
            {
                if (j == 0 || j == height - 1)
                    Console.WriteLine(new String(frameChar, width));
                else
                    Console.WriteLine($"{frameChar}{new String(' ', width - 2)}{frameChar}");
            }
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int j = 0;
            while(j < height)
            {
                if (j == 0 || j == height - 1)
                    Console.WriteLine(new String(frameChar, width));
                else
                    Console.WriteLine($"{frameChar}{new String(' ', width - 2)}{frameChar}");
                j++;
            }
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            if (b == 0)
                return a;
            else
                return Gcd(b, a % b);

        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            double res = 1;
            double fact = 1;
            double pow = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                pow *= x;
                res += pow / fact;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 3, '+');
            PrintFrame2(5, 3, '+');
            Console.WriteLine(Gcd(9, 444));
            Console.WriteLine(ExpTaylor(10, 100));
        }
    }
}