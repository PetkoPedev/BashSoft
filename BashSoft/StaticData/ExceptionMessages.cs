namespace BashSoft.StaticData
{
    public static class ExceptionMessages
    {
        public const string ExceptionMessage = "Example message";

        public const string UnauthorizedAccessExceptionMessage = "The folder/file you are trying to get access needs a higher level of rights than you currently have.";

        public const string ComparisonOfFilesWithDifferentSizes = "Files not of equal size, certain mismatch.";

        public const string ForbiddenSymbolsContainedInName = "The given name contains symbols that are not allowed to be used in names of files and folders.";

        public const string UnableToGoHigherInPartitionHierarhy = "User is not able to go higher in the folder hierarhy";

        public const string UnableToParseNumber = "The sequence you've written is not a valid number.";

        public const string InvalidTakeQuantityParameter = "The take command expected does not match the format wanted!";

        public const string InvalidScore = "The number for the score you've entered is not in the range of 0 - 100";
    }
}