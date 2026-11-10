using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task5.V21.Lib
{
    public class DataService : ISprint4Task5V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Создаем копию матрицы для результата
            int[,] resultMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Если элемент положительный (> 0), заменяем его на 1
                    if (matrix[i, j] > 0)
                    {
                        resultMatrix[i, j] = 1;
                    }
                    else
                    {
                        resultMatrix[i, j] = matrix[i, j];
                    }
                }
            }

            return resultMatrix;
        }
    }
}
