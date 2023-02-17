namespace ReadingUpdate;

internal class Comparisons
{
    public static string[] Comparison(List<string> termsList, Dictionary<string, string> carriersAndDrivers)
    {
        var result = new string[termsList.Count];
        for (var i = 0; i < termsList.Count; i++)
        {
            if (!carriersAndDrivers.ContainsKey(termsList[i])) continue;
            var keyIs = termsList[i];
            result[i] = carriersAndDrivers[keyIs];
        }
        
        return result;
    }

    public static string ResultingValue(string initialResult)
    {
        return initialResult switch
        {
            "NET 7 2%" => "NET 7",
            "DUE ON RECEIPT" => "NET 4",
            _ => initialResult
        };
    }
}