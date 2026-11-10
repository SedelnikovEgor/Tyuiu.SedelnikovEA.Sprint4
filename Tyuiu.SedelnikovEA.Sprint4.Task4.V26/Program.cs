using Tyuiu.SedelnikovaEA.Sprint4.Task4.V26.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task4.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int columns = 5;
            int[,] mas2D = new int[rows, columns];

            Console.WriteLine("Введите элементы матрицы 5 на 5 (значения от 1 до 5):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите элемент [{i}, {j}]: ");
                    mas2D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Исходная матрица:");
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

            Console.WriteLine("Результат после замены нечетных элементов на 0:");
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
