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
            x = 6;
            y = 4;
            var res = Math.Round(ds.Calculate(x, y), 3);
            double wait = -0.766;
            Assert.AreEqual(wait, res);

        }
    }
}
