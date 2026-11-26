using HomeWork7_Algorithm.Task1_number_of_digit_;
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
                int count=numberOfDigit.CountDigit(inputNumForCountDigit);
                Console.WriteLine(count);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
            }
            

        }
    }
}
