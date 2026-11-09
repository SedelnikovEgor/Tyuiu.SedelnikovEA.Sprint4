using System;
using Tyuiu.SedelnikovaEA.Sprint4.Task0.V5.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumEvenArrEl()
        {
            DataService ds = new DataService();

            // Статический массив из задания
            int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };

            // Ожидаемая сумма четных чисел (8 + 4 + 2 + 4 + 6)
            int expected = 24;

            int res = ds.GetSumEvenArrEl(numsArray);

            Assert.AreEqual(expected, res);
        }
    }
}
