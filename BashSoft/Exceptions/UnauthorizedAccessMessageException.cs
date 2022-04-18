namespace BashSoft.Exceptions
{
    public class UnauthorizedAccessMessageException : Exception
    {
        private const string UnauthorizedAccessExceptionMessage = "The folder/file you are trying to get access needs a higher level of rights than you currently have.";

        public UnauthorizedAccessMessageException() : base(UnauthorizedAccessExceptionMessage)
        {

        }

        public UnauthorizedAccessMessageException(string message) : base(message)
        {

        }
    }
}
