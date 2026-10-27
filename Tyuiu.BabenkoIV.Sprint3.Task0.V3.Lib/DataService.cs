using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkoIV.Sprint3.Task0.V3.Lib
{
    public class DataService : ISprint3Task0V3
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0.0;
            double constant = 0.25; //(1/2)^2

            for (int i = startValue; i <= stopValue; i++)
            {
                sum += Math.Sin(i) * constant;
            }

            return Math.Round(sum,3);
        }
    }
}
