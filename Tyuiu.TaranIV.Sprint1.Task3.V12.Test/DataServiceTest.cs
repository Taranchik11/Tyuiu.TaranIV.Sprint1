using Tyuiu.TaranIV.Sprint1.Task3.V12.Lib;

namespace Tyuiu.TaranIV.Sprint1.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpession()
        {
            DataService ds = new DataService();
            double x = 2.3;
            double y = 2.5;
            var wait = (x * y) / 2;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

