using Tyuiu.TaranIV.Sprint1.Task1.V0.Lib;

namespace Tyuiu.TaranIV.Sprint1.Task1.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 7;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(42, res);

        }
    }
}