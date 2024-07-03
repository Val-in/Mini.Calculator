using Mini.Calculator.MyLogger;

namespace Mini.Calculator
{
    public class SumTwoNumbers : ISum
    {
        private readonly ILogger _logger;

        public SumTwoNumbers(ILogger logger)
        { 
            _logger = logger;   
        }

        public decimal Sum(decimal a, decimal b)
        {
            _logger.Event("The program is summing two numbers.");
            return a + b;
        }
    }
}
