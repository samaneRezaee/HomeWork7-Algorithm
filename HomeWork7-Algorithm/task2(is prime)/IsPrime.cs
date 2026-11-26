

namespace HomeWork7_Algorithm.task2_is_prime_
{
    public class IsPrime
    {
        long inputNum;
        public bool isPrime(long inputNum)
        {
            if (inputNum <= 1) return false;
            if (inputNum == 2) return true;
            if (inputNum % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(inputNum); i += 2)
            {
                if (inputNum % i == 0) return false;
            }
            return true;
        }
    }
}
