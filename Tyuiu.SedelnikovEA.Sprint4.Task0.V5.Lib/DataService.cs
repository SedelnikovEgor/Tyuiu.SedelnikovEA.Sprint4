using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task0.V5.Lib
{
    public class DataService : ISprint4Task0V5
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;

            // Цикл перебирает все элементы одномерного массива
            for (int i = 0; i < array.Length; i++)
            {
                // Проверка элемента на четность
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }
    }
}
