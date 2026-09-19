using Tyuiu.TaranIV.Sprint1.Task4.V23.Lib;

namespace Tyuiu.TaranIV.Sprint1.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double res = 2;
            var value = ds.Calculate(x, y);
            Assert.AreEqual(res, value);
        }
    }
}
