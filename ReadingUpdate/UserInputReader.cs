using System.ComponentModel.Design;

namespace ReadingUpdate;

internal class UserInputReader
{
    public static bool InputValidity(string firstFile, string secondFile)
    {
        if (firstFile == secondFile)
        {
            DisplayMessage(3);
            return false;
        }

        if (!(firstFile.Contains(".txt") && secondFile.Contains(".txt")))

        {
            DisplayMessage(5);
            return false;
        }
        return true;
    }

    public static string CheckingNullUserInput()
    {
        var path = ReadLine();
        while (true)
        {
            if (!string.IsNullOrEmpty(path)) break;
            WriteLine("Please enter a valid path");
            path = ReadLine();

        }
        return path;
    }

}