namespace BreakingSingleResponsibility
{
    public class Log 
    {
        private readonly ILogStuf _logger;

        public Log(ILogStuf logger)
        {
            _logger = logger;
        }


        public static void Logit(string toString)
        {
            throw new System.NotImplementedException();
        }
    }
}
