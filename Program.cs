using Mini.Calculator.MyLogger;

namespace Mini.Calculator
{
    public class Program
    {
        public static ILogger logger = new Logger();
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                decimal a = EnterNumber();

                Console.WriteLine("Enter the second number:");
                decimal b = EnterNumber();

                ISum calculator = new SumTwoNumbers(logger);
                decimal result = calculator.Sum(a, b);

                Console.WriteLine($"The sum is: {result}");
            }
            catch (FormatException ex)
            {
                logger.Error("Invalid number format: " + ex.Message);
            }
            catch (Exception ex)
            {
                logger.Error("An error occurred: " + ex.Message);
            }
            finally
            {
                logger.Event("Calculation finished.");
            }
        }

        public static decimal EnterNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal number))
                {
                    return number;
                }
                else
                {
                    logger.Error("Enter a valid number!"); //покрасить в красный
                }
            }
        }
    }
}
