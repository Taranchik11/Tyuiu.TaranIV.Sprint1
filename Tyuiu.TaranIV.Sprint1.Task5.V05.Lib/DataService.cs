using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TaranIV.Sprint1.Task5.V05.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double result = (x - Math.Truncate(x)) * 10;
            double result1 = Math.Truncate(result);
            int value = Convert.ToInt32 (result1);
            return value;
        }
    }
}
