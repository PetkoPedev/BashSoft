namespace BashSoft.Exceptions
{
    public class InexistingStudentInDataBaseException : Exception
    {
        private const string InexistingStudentInDataBase = "The user name for the student you are trying to get does not exist!";

        public InexistingStudentInDataBaseException() : base(InexistingStudentInDataBase)
        {

        }

        public InexistingStudentInDataBaseException(string message) : base(message)
        {

        }
    }
}
