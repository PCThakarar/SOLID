namespace DIP_Applied
{
    public interface ILogger
    {
        void Log(string message);
        void Info(string message);
        void Debug(string message);
    }
}
