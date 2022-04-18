namespace BashSoft.Exceptions
{
    public class InvalidStudentFilterException : Exception
    {
        private const string InvalidStudentFilter = "The given filter is not one of the following: excellent/average/poor";

        public InvalidStudentFilterException() : base(InvalidStudentFilter)
        {

        }

        public InvalidStudentFilterException(string message) : base(message)
        {

        }
    }
}
