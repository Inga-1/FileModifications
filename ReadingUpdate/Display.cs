namespace ReadingUpdate;

internal class Display
{
    public static void DisplayMessage(int index)
    {
        switch (index)
        {
            case 1:
                WriteLine("Please enter the path for your first file\nPlease ensure that the entered path is valid and contains the desired file\nYour first file is the one that includes info only about Carriers and Terms");
                break;
            case 2:
                WriteLine("Please enter the path for your second file\nPlease ensure that the entered path is valid and contains the desired file\nThe obtained info will be overwritten to this file\nTherefore, it should contain info about the carrier fees, the customers, etc");
                break;
            case 3:
                WriteLine("The entered paths are identical. Please enter new paths");
                break;
            case 4:
                WriteLine("Everything is now fully done.\nPlease check your second file to find the obtained results");
                break;
            case 5:
                WriteLine("The paths are in the wrong format. Are you sure you have included your .txt file in it?");
                break;
        }
    }
}