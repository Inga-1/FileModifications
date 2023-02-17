namespace ReadingUpdate;

public class Calculations
{
    public static float CalculatingTheValue(float value, string resultingString) 
        //value is the int received from the ToBePaid file 
        //resultingString is what we got from comparisons, aka NET 7 etc 
    {
        var result = new float();
        return resultingString switch
        {
            "NET 7" => (float)(value * 0.07),
            "NET 4" => (float)(value * 0.04),
            _ => -1
        };
    }
}