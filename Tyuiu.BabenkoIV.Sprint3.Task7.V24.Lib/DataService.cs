using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkoIV.Sprint3.Task7.V24.Lib
{
    public class DataService : ISprint3Task7V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] results = new double[size];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = x + 1.2;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.000001)
                {
                    results[index] = 0;
                }
                else
                {
                    // Вычисление значения функции
                    double fx = (Math.Sin(x) / denominator) - (Math.Sin(x) * 2) - (2 * x);

                    // Округление до 2 знаков после запятой
                    results[index] = Math.Round(fx, 2);
                }

                index++;
            }

            return results;
        }
    }
}
