namespace SingletonProject
{
    public class Logger
    {
        private static Logger? _instance;

        private Logger()
        {

        }

        public static Logger Instance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }

            return _instance;
        }

        public void Log(string message)
        {
            //singleton operation
            Console.WriteLine(message);
        }
    }
}
