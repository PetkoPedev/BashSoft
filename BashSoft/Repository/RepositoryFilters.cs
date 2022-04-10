using BashSoft.IO;
using BashSoft.StaticData;

namespace BashSoft.Repository
{
    public static class RepositoryFilters
    {
        public static void FilterAndTake(
            Dictionary<string, List<int>> wantedData, 
            string wantedFilter, 
            int studentsTotake)
        {
            if (wantedFilter == "excellent")
            {
                FilterAndTake(wantedData, x => x >= 5, studentsTotake);
            }
            else if(wantedFilter == "average")
            {
                FilterAndTake(wantedData, x => x < 5 && x >= 3.5, studentsTotake);
            }
            else if(wantedFilter == "poor")
            {
                FilterAndTake(wantedData, x => x < 3.5, studentsTotake);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidStudentFilter);
            }
        }

        private static void FilterAndTake(
            Dictionary<string, List<int>> wantedData, 
            Predicate<double> givenFilter, 
            int studentsTotake)
        {
            int counterForPrinted = 0;
            foreach (var studentPoints in wantedData)
            {
                if (counterForPrinted == studentsTotake)
                {
                    break;
                }

                double averageScore = studentPoints.Value.Average();
                double percentageOffulfillment = averageScore / 100;
                double averageMark = percentageOffulfillment * 4 + 2;
                if (givenFilter(averageMark))
                {
                    OutputWriter.PrintStudent(studentPoints);
                    counterForPrinted++;
                }
            }
        }
    }
}
