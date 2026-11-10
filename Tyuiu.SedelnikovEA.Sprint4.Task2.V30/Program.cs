using System;
using Tyuiu.SedelnikovaEA.Sprint4.Task2.V30.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task2.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 12;
            int[] numsArray = new int[len];

            // Заполнение массива случайными значениями от 2 до 8
            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(2, 9); // Верхняя граница в Next() не включается
            }

            Console.WriteLine("Исходный массив (сгенерирован случайно): ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Произведение нечетных элементов массива равно: " + res);

            Console.ReadLine();
        }
    }
}
