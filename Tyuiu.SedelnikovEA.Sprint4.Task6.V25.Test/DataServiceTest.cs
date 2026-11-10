using Tyuiu.SedelnikovaEA.Sprint4.Task6.V25.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] sports = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
            int expected = 2; // "Баскетбол" (9) и "Бейсбол" (7)

            int res = ds.Calculate(sports);

            Assert.AreEqual(expected, res);
        }
    }
}
