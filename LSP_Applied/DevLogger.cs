namespace LSP_Applied
{
    internal class DevLogger : Logger
    {
        public override void Debug(string message)
        {
            Console.WriteLine($"Dev Debug -> {message}");
        }
    }
}
