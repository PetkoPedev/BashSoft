﻿namespace BashSoft
{
    public static class InputReader
    {
        private const string endCommand = "quit";

        public static void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}>");
            string input = Console.ReadLine();
            input = input.Trim();

            while (true)
            {
                CommandInterpreter.InterpredCommand(input);
                OutputWriter.WriteMessage($"{SessionData.currentPath}>");
                input = Console.ReadLine();
                input = input.Trim();

                if (input == endCommand)
                {
                    break;
                }
            }
        }
    }
}
