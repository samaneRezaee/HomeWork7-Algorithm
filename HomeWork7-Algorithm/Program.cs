using HomeWork7_Algorithm.Task1_number_of_digit_;
using HomeWork7_Algorithm.task2_is_prime_;
using SharedCore;
namespace HomeWork7_Algorithm
{
    public class Program
    {
        static void Main(string[] args)
        {

            //task 1 countDigit
            NumberOfDigit numberOfDigit = new NumberOfDigit();
            try
            {
                int inputNumForCountDigit = GetInputs.getInputNumInt();
                if (inputNumForCountDigit < 0)
                {
                    throw new Exception("Number must be positive.");
                }
                int count = numberOfDigit.CountDigit(inputNumForCountDigit);
                Console.WriteLine(count);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
            }

            //task2 IsPrime
            IsPrime isPrimeObj = new IsPrime();
            var inputNumToCheckIsPrime = GetInputs.getInputNum();
            bool resultIsPrime=isPrimeObj.isPrime(inputNumToCheckIsPrime);
            if (resultIsPrime)
                Console.WriteLine($"Input is a 'Prime Number' ");
            else
                Console.WriteLine($"Input is not a prime number!!!");
            Console.WriteLine();

        }
    }
}
