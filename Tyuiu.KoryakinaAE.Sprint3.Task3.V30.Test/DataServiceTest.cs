using Tyuiu.KoryakinaAE.Sprint3.Task3.V30.Lib;

namespace Tyuiu.KoryakinaAE.Sprint3.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetMaxCharCount("fyyklbtyn ygrc vfyyyyh", 'y');
            Assert.AreEqual(4, res);
        }
    }
}
