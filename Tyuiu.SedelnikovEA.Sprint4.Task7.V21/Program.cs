using Tyuiu.SedelnikovaEA.Sprint4.Task7.V12.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task7.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 3;
            int columns = 4;
            string str = "658932125478";

            Console.WriteLine("Строка из цифр: " + str);
            Console.WriteLine($"Размеры матрицы: {rows} на {columns}");
            Console.WriteLine();

            Console.WriteLine("Сформированная матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(str[i * columns + j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, columns, str);

            Console.WriteLine("Сумма нечетных чисел в матрице равна: " + res);

            Console.ReadLine();
        }
    }
}
