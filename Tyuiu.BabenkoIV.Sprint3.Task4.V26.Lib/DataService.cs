using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkoIV.Sprint3.Task4.V26.Lib
{
    public class DataService : ISprint3Task4V26
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }

                double y = (Math.Cos(x) - Math.Sin(x)) / x;
                sum += y;
            }

            return Math.Round(sum,3);
        }
    }
}
