using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace ReadingUpdate;

internal class ReadingFiles
{
    public static Dictionary<string, string> ReadingTheFirstFile(string path)
    {
        Dictionary<string, string> carriersAndTerms = new();
        var contents = File.ReadAllLines(path);

        foreach (var content in contents)
        {
            var carrier = content.Split('\t')[0];
            var term = content.Split("\t")[1];
            carriersAndTerms.Add(carrier, term);
        }
        return carriersAndTerms;
    }

    public static List<string> ReadingTheSecondFile(string path, int index)
    {
        var result = new List<string>();
        var contents = File.ReadAllLines(path);
        for (var i = 1; i < contents.Length; i++)
        {
            result.Add(contents[i].Split('\t')[index]); 
        }
        return result;
    }

    public static List<List<string>> ReadingTheSecondFileInFull(string path)
    {
        var contents = File.ReadAllLines(path);
        return contents.Select(t => new List<string>(t.Split('\t'))).ToList();
    }

}