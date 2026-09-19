using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TaranIV.Sprint1.Task4.V23.Lib
{
    public class DataService : ISprint1Task4V23
    {
        public double Calculate(double x, double y)
        {
            double result1 = Math.Abs(Math.Sqrt(x + y));
            double result2 = Math.Abs(3 - x);
            return Math.Round(result1 / result2, 3);
        }
    }
}
