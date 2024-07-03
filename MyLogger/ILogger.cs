namespace Mini.Calculator.MyLogger
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
