using Tyuiu.TaranIV.Sprint1.Task5.V5.Lib;


namespace Tyuiu.TaranIV.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.521;
            int d = ds.Calculate(x);
            int wait = 5;
            Assert.AreEqual(wait, d);
        }
    }
}
