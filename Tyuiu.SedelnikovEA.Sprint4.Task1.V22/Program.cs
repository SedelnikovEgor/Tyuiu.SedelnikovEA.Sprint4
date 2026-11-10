using System;
using Tyuiu.SedelnikovaEA.Sprint4.Task1.V22.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 12;
            int[] numsArray = new int[len];

            Console.WriteLine("Введите элементы массива (всего " + len + " в диапазоне от 2 до 9):");
            for (int i = 0; i < len; i++)
            {
                Console.Write($"Введите значение {i}-го элемента: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Исходный массив: ");
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
