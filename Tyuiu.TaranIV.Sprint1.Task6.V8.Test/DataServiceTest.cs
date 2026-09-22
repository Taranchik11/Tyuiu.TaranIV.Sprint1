using System.Security.Cryptography;
using Tyuiu.TaranIV.Sprint1.Task6.V8.Lib;

namespace Tyuiu.TaranIV.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string input = "Hello my friend";
            string result = ds.MoveLetterToEnd(input);
            string wait = "elloH ym riendf"; 
            Assert.AreEqual(wait, result);

        }
    }
}
