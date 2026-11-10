using Tyuiu.SedelnikovaEA.Sprint4.Task5.V21.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2D = new int[,] {
                { -5,  4, -1,  1, -2 },
                { -3,  2, -4, -3,  0 },
                { -8, -2,  1, -2, -2 },
                { -2, -5, -1, -1,  2 },
                { -5, -3, -4, -3, -2 }
            };

            int[,] expected = new int[,] {
                { -5,  1, -1,  1, -2 },
                { -3,  1, -4, -3,  0 },
                { -8, -2,  1, -2, -2 },
                { -2, -5, -1, -1,  1 },
                { -5, -3, -4, -3, -2 }
            };

            int[,] res = ds.Calculate(mas2D);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
