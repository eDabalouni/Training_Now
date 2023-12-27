namespace TrainingAPIs.Logging
{
    public class LoggingV2 : ILogging
    {
        public void Log(string message, string type)
        {
            if (type == "error")
            {
                Console.WriteLine("ERROR v2- " + message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
