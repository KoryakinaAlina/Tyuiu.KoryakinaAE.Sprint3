using Tyuiu.KoryakinaAE.Sprint3.Task4.V24.Lib;
namespace Tyuiu.KoryakinaAE.Sprint3.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 46.750;
            Assert.AreEqual(wait, res);

        }
    }
}
