using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkoIV.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double product = 1.0;
            int i = startValue;

            do
            {
                product *= (Math.Pow(value, 2) * i) + 2;
                i++;
            } while (i <= stopValue);

            return Math.Round(product,3);
        }
    }
}
