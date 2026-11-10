using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] matrix)
        {
            // Берем первый элемент первой строки в качестве начального максимума
            int max = matrix[0, 0];

            // Перебираем элементы только первой строки (индекс строки = 0)
            // matrix.GetLength(1) возвращает количество столбцов (в данном случае 5)
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[0, j] > max)
                {
                    max = matrix[0, j];
                }
            }

            return max;
        }
    }
}
