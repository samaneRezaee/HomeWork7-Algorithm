

namespace HomeWork7_Algorithm.Task1_number_of_digit_
{
    public class NumberOfDigit
    {
        public int CountDigit(int inputNum)
        {
            int count = 0;

            if (inputNum == 0)
                return 1;
            while (inputNum > 0)
            {
                count++;
                inputNum /= 10;
            }
            return count;
        }

    }
}

