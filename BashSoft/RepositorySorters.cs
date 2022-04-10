namespace BashSoft
{
    public static class RepositorySorters
    {
        public static void OrderAndTake(Dictionary<string, List<int>> wantedData, string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();
            if (comparison == "ascending")
            {
                OrderAndTake(wantedData, studentsToTake, CompareInOrder);
            }
            else if (comparison == "descending")
            {
                OrderAndTake(wantedData, studentsToTake, CompareDescendingOrder);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidComparisonQuery);
            }
        }

        private static Dictionary<string, List<int>> GetSortedStudents(
            Dictionary<string, List<int>> wantedData, 
            int studentsToTake, Func<KeyValuePair<string, List<int>>, 
                KeyValuePair<string, List<int>>, int> comparisonFunc)
        {
            int studentsTaken = 0;
            Dictionary<string, List<int>> studentsSorted = new Dictionary<string, List<int>>();
            KeyValuePair<string, List<int>> nextInOrder = new KeyValuePair<string, List<int>>();
            while (studentsTaken < studentsToTake)
            {
                bool isSorted = true;
                foreach (var studentScore in wantedData)
                {
                    if (!string.IsNullOrEmpty(nextInOrder.Key))
                    {
                        int comparisonResult = comparisonFunc(studentScore, nextInOrder);
                        if (comparisonResult >= 0 && !studentsSorted.ContainsKey(studentScore.Key))
                        {
                            nextInOrder = studentScore;
                            isSorted = false;
                        }
                    }
                    else
                    {
                        if (!studentsSorted.ContainsKey(studentScore.Key))
                        {
                            nextInOrder = studentScore;
                            isSorted = false;
                        }
                    }
                }
                if (!isSorted)
                {
                    studentsSorted.Add(nextInOrder.Key, nextInOrder.Value);
                    studentsTaken++;
                    nextInOrder = new KeyValuePair<string, List<int>>();
                }
            }

            return studentsSorted;
        }

        private static void OrderAndTake(
            Dictionary<string, List<int>> wantedData, 
            int studentsToTake, 
            Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> comparisonFunc)
        {
            var studentsSorted = GetSortedStudents(wantedData, studentsToTake, comparisonFunc);
            foreach (var student in studentsSorted)
            {
                OutputWriter.PrintStudent(student);
            }
        }

        private static int CompareInOrder(KeyValuePair<string, List<int>> firstValue, KeyValuePair<string, List<int>> secondValue)
        {
            int totalScoreOfFirst = 0;
            foreach (var mark in firstValue.Value)
            {
                totalScoreOfFirst += mark;
            }

            int totalScoreOfSecond = 0;
            foreach (var mark in firstValue.Value)
            {
                totalScoreOfSecond += mark;
            }

            return totalScoreOfSecond.CompareTo(totalScoreOfFirst);
        }

        private static int CompareDescendingOrder(KeyValuePair<string, List<int>> firstValue, KeyValuePair<string, List<int>> secondValue)
        {
            int totalScoreOfFirst = 0;
            foreach (var mark in firstValue.Value)
            {
                totalScoreOfFirst += mark;
            }

            int totalScoreOfSecond = 0;
            foreach (var mark in firstValue.Value)
            {
                totalScoreOfSecond += mark;
            }

            return totalScoreOfFirst.CompareTo(totalScoreOfSecond);
        }
    }
}