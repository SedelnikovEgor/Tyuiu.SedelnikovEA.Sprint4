using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task4.V26.Lib
{
    public class DataService : ISprint4Task4V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Создаем копию матрицы для вычислений, чтобы не менять исходную
            int[,] resultMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Если элемент нечетный, заменяем его на 0
                    if (matrix[i, j] % 2 != 0)
                    {
                        resultMatrix[i, j] = 0;
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
