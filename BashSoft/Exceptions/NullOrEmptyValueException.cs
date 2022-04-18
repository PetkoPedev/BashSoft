namespace BashSoft.Exceptions
{
    public class NullOrEmptyValueException : Exception
    {
        private const string NullOrEmptyValue = "The value of the variable CANNOT be null or empty!";

        public NullOrEmptyValueException() : base(NullOrEmptyValue)
        {

        }

        public NullOrEmptyValueException(string message) : base(message)
        {

        }
    }
}
