using Tyuiu.SedelnikovaEA.Sprint4.Task2.V30.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Пример тестового массива: нечетные числа здесь — 3, 5, 7
            int[] numsArray = { 2, 3, 4, 5, 6, 7, 8, 2, 4, 6, 8, 2 };

            // Ожидаемый результат: 3 * 5 * 7 = 105
            int expected = 105;

            int res = ds.Calculate(numsArray);

            Assert.AreEqual(expected, res);
        }
    }
}
