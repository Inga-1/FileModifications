namespace ReadingUpdate;

public class Transformations
{
    public static List<float> TransformationToNumbers(List<string> values)
    {
        return values.Select(float.Parse).ToList();
    }

    public static List<string> TransformToString(List<float> values)
    {
        return values.Select(t => t.ToString()).ToList();
    }
}