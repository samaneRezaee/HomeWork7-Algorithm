

namespace HomeWork7_Algorithm.task_3_sum_digit_
{
    public class SumDigit
    {
        public int SumDigitNum(long num)
        {
            long sum =0;
            num = Math.Abs(num);

            while (num > 0) 
            {
                sum += num % 10;
                num /= 10;
            }
            return (int)sum;
        }
    }
}
