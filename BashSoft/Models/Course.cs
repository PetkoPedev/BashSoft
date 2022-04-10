using BashSoft.IO;
using BashSoft.StaticData;

namespace BashSoft.Models
{
    public class Course
    {
        public const int NumberOfTasksOnExam = 5;
        public const int MaxScoreOnExamTask = 100;

        public Course(string name)
        {
            this.Name = name;
            this.studentsByName = new Dictionary<string, Student>();
        }

        public string Name;
        public Dictionary<string, Student> studentsByName;

        public void EnrollStudent(Student student)
        {
            if (this.studentsByName.ContainsKey(student.Username))
            {
                OutputWriter.DisplayException(String.Format(ExceptionMessages.StudentAlreadyEnrolledInGivenCourse, student.Username, this.Name));
                return;
            }

            this.studentsByName.Add(student.Username, student);
        }
    }
}