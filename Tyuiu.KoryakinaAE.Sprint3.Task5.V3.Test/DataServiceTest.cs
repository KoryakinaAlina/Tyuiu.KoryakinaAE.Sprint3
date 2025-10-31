using Tyuiu.KoryakinaAE.Sprint3.Task5.V3.Lib;
namespace Tyuiu.KoryakinaAE.Sprint3.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(33.247, dataService.GetSumSumSeries(5, 1, 1, 3, 11));
        }
    }
}
