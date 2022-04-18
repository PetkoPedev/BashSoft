namespace BashSoft.Exceptions
{
    public class ForbiddenSymbolsContainedInNameException : Exception
    {
        private const string ForbiddenSymbolsContainedInName = "The given name contains symbols that are not allowed to be used in names of files and folders.";

        public ForbiddenSymbolsContainedInNameException() : base(ForbiddenSymbolsContainedInName)
        {

        }

        public ForbiddenSymbolsContainedInNameException(string message) : base(message)
        {

        }
    }
}
