namespace DIP_Applied
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Info(string message)
        {
            Console.WriteLine($"Info: {message}");
        }

        public void Debug(string message)
        {
            Console.WriteLine($"Debug: {message}");
        }
    }
}
