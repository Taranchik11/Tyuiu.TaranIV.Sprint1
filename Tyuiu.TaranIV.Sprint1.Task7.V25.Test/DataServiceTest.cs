using Tyuiu.TaranIV.Sprint1.Task7.V25.Lib;

namespace Tyuiu.TaranIV.Sprint1.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x, y;
            x = 2;
            y = 4;
            var res = ds.Calculate(x,y);
            var wait = 6.733;
            Assert.AreEqual(wait, res);

        }
    }
}
