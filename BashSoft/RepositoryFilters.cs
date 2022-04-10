namespace BashSoft
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
                FilterAndTake(wantedData, ExcelentFilter, studentsTotake);
            }
            else if(wantedFilter == "average")
            {
                FilterAndTake(wantedData, AverageFilter, studentsTotake);
            }
            else if(wantedFilter == "poor")
            {
                FilterAndTake(wantedData, PoorFilter, studentsTotake);
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

                double averageMark = Average(studentPoints.Value);
                if (givenFilter(averageMark))
                {
                    OutputWriter.PrintStudent(studentPoints);
                    counterForPrinted++;
                }
            }
        }

        private static bool ExcelentFilter(double mark)
        {
            return mark >= 5.0;
        }

        private static bool AverageFilter(double mark)
        {
            return mark < 5.0 && mark >= 3.5;
        }

        private static bool PoorFilter(double mark)
        {
            return mark < 3.5;
        }

        private static double Average(List<int> scoresOnTasks)
        {
            int totalScore = 0;
            foreach (var score in scoresOnTasks)
            {
                totalScore += score;
            }

            var percentageOfAll = totalScore / (scoresOnTasks.Count * 100);
            var mark = percentageOfAll * 4 + 2;

            return mark;
        }
    }
}
