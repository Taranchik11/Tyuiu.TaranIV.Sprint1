using Tyuiu.TaranIV.Sprint1.Task2.V21.Lib;

namespace Tyuiu.TaranIV.Sprint1.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpession()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 7;
            var res = ds.CalculateRectangleSquare(x, y);
            Assert.AreEqual(21, res);
        }
    }
}
