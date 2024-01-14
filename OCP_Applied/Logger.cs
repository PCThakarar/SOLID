namespace OCP_Applied
{
    public class Logger
    {
        public virtual void Log(string message)
        {
            Console.WriteLine(message);
        }

        public virtual void Info(string message)
        {
            Console.WriteLine($"Info: {message}");
        }

        public virtual void Debug(string message)
        {
            Console.WriteLine($"Debug: {message}");
        }
    }
}
