using Tyuiu.SedelnikovaEA.Sprint4.Task7.V12.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int rows = 3;
            int columns = 4;
            string str = "658932125478";
            int expected = 30;

            int res = ds.Calculate(rows, columns, str);

            Assert.AreEqual(expected, res);
        }
    }
}
