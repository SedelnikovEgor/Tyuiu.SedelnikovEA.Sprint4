using Tyuiu.SedelnikovaEA.Sprint4.Task5.V21.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task5.V21
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

            int rows = 5;
            int columns = 5;
            int[,] mas2D = new int[rows, columns];

            // Заполнение матрицы случайными числами от -8 до 2
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mas2D[i, j] = rnd.Next(-8, 3); // Верхняя граница в Next() не включается
                }
            }

            Console.WriteLine("Исходная матрица (сгенерирована случайно от -8 до 2):");
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

            int[,] resMatrix = ds.Calculate(mas2D);

            Console.WriteLine("Результат после замены положительных элементов на 1:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(resMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
