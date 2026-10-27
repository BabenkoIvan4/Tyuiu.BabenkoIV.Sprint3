using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkoIV.Sprint3.Task1.V25.Lib
{
    public class DataService : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1.0;
            int k = startValue;
            double cos5 = Math.Cos(5);

            while (k <= stopValue)
            {
                product *= (Math.Pow(value, k) - 0.25) * cos5;
                k++;
            }

            return product;
        }
    }
}
