using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkoIV.Sprint3.Task6.V10.Lib
{
    public class DataService : ISprint3Task6V10
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0) // Если d является делителем числа x
                    {
                        if (d > 12) // Проверяем условие задачи: делитель строго больше 12
                        {
                            sum += d;
                        }
                    }
                }
            }

            return sum;
        }
    }
}
