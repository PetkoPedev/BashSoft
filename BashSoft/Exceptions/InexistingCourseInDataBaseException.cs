namespace BashSoft.Exceptions
{
    public class InexistingCourseInDataBaseException : Exception
    {
        private const string InexistingCourseInDataBase = "The course you are trying to get does not exist in the data base!";

        public InexistingCourseInDataBaseException() : base(InexistingCourseInDataBase)
        {

        }

        public InexistingCourseInDataBaseException(string message) : base(message)
        {

        }
    }
}
