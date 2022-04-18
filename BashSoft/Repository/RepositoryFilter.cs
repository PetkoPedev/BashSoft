using BashSoft.Exceptions;
using BashSoft.IO;

namespace BashSoft.Repository
{
    public class RepositoryFilter
    {
        public void FilterAndTake(Dictionary<string, double> studentsWithMarks, string wantedFilter, int studentsTotake)
        {
            if (wantedFilter == "excellent")
            {
                FilterAndTake(studentsWithMarks, x => x >= 5, studentsTotake);
            }
            else if(wantedFilter == "average")
            {
                FilterAndTake(studentsWithMarks, x => x < 5 && x >= 3.5, studentsTotake);
            }
            else if(wantedFilter == "poor")
            {
                FilterAndTake(studentsWithMarks, x => x < 3.5, studentsTotake);
            }
            else
            {
                throw new InvalidStudentFilterException();
            }
        }

        private void FilterAndTake(
            Dictionary<string, double> studentsWithMarks, 
            Predicate<double> givenFilter, 
            int studentsTotake)
        {
            int counterForPrinted = 0;
            foreach (var studentMark in studentsWithMarks)
            {
                if (counterForPrinted == studentsTotake)
                {
                    break;
                }

                if (givenFilter(studentMark.Value))
                {
                    OutputWriter.PrintStudent(new KeyValuePair<string, double>(studentMark.Key, studentMark.Value));
                    counterForPrinted++;
                }
            }
        }
    }
}
