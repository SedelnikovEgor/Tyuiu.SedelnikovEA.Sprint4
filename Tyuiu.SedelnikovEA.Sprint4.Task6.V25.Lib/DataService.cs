using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task6.V25.Lib
{
    public class DataService : ISprint4Task6V25
    {
        public int Calculate(string[] array)
        {
            // Используем класс Array для поиска всех элементов с длиной строки больше 6
            string[] result = Array.FindAll(array, x => x.Length > 6);

            // Возвращаем количество найденных элементов
            return result.Length;
        }
    }
}
