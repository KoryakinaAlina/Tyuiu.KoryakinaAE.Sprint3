using Tyuiu.KoryakinaAE.Sprint3.Task0.V8.Lib;

namespace Tyuiu.KoryakinaAE.Sprint3.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 0.25;
            int start = 1;
            int end = 10;
            double res = ds.GetMultiplySeries(a, start, end);
            double wait = 0.019;
            Assert.AreEqual(res, wait);

        }
    }
}
