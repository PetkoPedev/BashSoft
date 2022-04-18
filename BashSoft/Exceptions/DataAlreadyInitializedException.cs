namespace BashSoft.Exceptions
{
    public class DataAlreadyInitializedException : Exception
    {
        private const string DataAlreadyInitialized = "Data is already initialized!";

        public DataAlreadyInitializedException() : base(DataAlreadyInitialized)
        {

        }

        public DataAlreadyInitializedException(string message) : base(message)
        {

        }
    }
}
