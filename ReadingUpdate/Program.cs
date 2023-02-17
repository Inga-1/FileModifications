using static System.String;

namespace ReadingUpdate;

internal class Program
{
    private static async Task Main()
    {
        //obtaining the files
        DisplayMessage(1);
        var firstPath = CheckingNullUserInput();
        DisplayMessage(2);
        var secondPath = CheckingNullUserInput();

        while (!InputValidity(firstPath, secondPath))
        {
            DisplayMessage(1);
            firstPath = CheckingNullUserInput();
            DisplayMessage(2);
            secondPath = CheckingNullUserInput();
        }

        
        //initializations 
        var firstFile = ReadingTheFirstFile(firstPath);
        var carriersAndTerms = ReadingTheSecondFile(secondPath, 2); //carrier and driver names 

        var carrierVals = Comparison(carriersAndTerms, firstFile); //converting from e.g. NET 7 2% to NET 7, etc 
        var finalNETVals = carrierVals.Select(ResultingValue).ToList(); //grouping the abovementioned vals together in a list


        var carrierFeesAsStrings = ReadingTheSecondFile(secondPath, 3); //carrier fees 
        var finalCarrierFeesList = TransformationToNumbers(carrierFeesAsStrings);

        var secondFile = ReadingTheSecondFileInFull(secondPath);
        List<float> calcResult = new();

        //calculations

        for (var i = 0; i < finalCarrierFeesList.Count; i++)
        {
            var resultingVal = CalculatingTheValue(finalCarrierFeesList[i], finalNETVals[i]);
            if (resultingVal != -1)
                calcResult.Add(resultingVal);
            else calcResult.Add(0);
        }

        finalNETVals.Insert(0, "TERMS");
        var finalCalc = TransformToString(calcResult);
        finalCalc.Insert(0, "RESULTS");
        for (var i = 0; i < finalCalc.Count; i++)
        {
            if (finalCalc[i] == "0")
            {
                finalCalc[i] = finalCalc[i].Replace("0", " ");
            }
        }

        for (var i = 0; i < finalNETVals.Count; i++)
        {
            secondFile[i].Add(finalNETVals[i]);
            secondFile[i].Add(finalCalc[i]);
            secondFile[i] = new List<string> { Join("\t", secondFile[i]) };
        }

        var result = secondFile.SelectMany(i => i);

        await File.WriteAllLinesAsync(secondPath, result);

        DisplayMessage(4);
    }
}