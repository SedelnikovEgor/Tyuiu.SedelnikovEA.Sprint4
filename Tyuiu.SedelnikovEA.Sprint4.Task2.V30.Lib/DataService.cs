using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task2.V30.Lib
{
    public class DataService : ISprint4Task2V30
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            bool hasOdd = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    p *= array[i];
                    hasOdd = true;
                }
            }

            // Если нечетных элементов в массиве не оказалось, произведение равно 0
            return hasOdd ? p : 0;
        }
    }
}
