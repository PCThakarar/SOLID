namespace DIP_Applied
{
    internal class DevLogger : ILogger
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
            Console.WriteLine($"Dev Debug -> {message}");
        }
    }
}
