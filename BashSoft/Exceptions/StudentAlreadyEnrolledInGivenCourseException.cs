namespace BashSoft.Exceptions
{
    public class StudentAlreadyEnrolledInGivenCourseException : Exception
    {
        private const string StudentAlreadyEnrolledInGivenCourse = "The {0} already exists in {1}.";

        public StudentAlreadyEnrolledInGivenCourseException(string message) : base(message)
        {

        }

        public StudentAlreadyEnrolledInGivenCourseException(string entry, string course) 
            : base(string.Format(StudentAlreadyEnrolledInGivenCourse, entry, course))
        {

        }
    }
}
