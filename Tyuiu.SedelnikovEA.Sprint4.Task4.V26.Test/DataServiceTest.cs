using Tyuiu.SedelnikovaEA.Sprint4.Task4.V26.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2D = new int[,] {
                { 5, 4, 1, 1, 2 },
                { 3, 2, 4, 3, 5 },
                { 5, 2, 3, 2, 2 },
                { 2, 5, 1, 1, 4 },
                { 5, 3, 4, 3, 2 }
            };

            int[,] expected = new int[,] {
                { 0, 4, 0, 0, 2 },
                { 0, 2, 4, 0, 0 },
                { 0, 2, 0, 2, 2 },
                { 2, 0, 0, 0, 4 },
                { 0, 0, 4, 0, 2 }
            };

            int[,] res = ds.Calculate(mas2D);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
