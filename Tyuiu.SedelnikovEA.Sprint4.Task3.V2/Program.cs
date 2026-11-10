using Tyuiu.SedelnikovaEA.Sprint4.Task3.V2.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mas2D = new int[5, 5] {
                { 4, 3, 2, 8, 7 },
                { 4, 6, 5, 5, 7 },
                { 3, 8, 8, 3, 5 },
                { 5, 7, 5, 4, 4 },
                { 8, 8, 3, 7, 6 }
            };

            int rows = mas2D.GetLength(0);
            int columns = mas2D.GetLength(1);

            Console.WriteLine("Двумерный массив массива (матрица 5х5):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mas2D[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas2D);

            Console.WriteLine("Максимальный элемент в первой строке равен: " + res);

            Console.ReadLine();
        }
    }
}
