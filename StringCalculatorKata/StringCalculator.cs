using System.Threading.Tasks.Sources;

namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string value)
    {
        if (string.IsNullOrEmpty(value))
            return 0;
        return SumStringValues(value);
    }

    private static int SumStringValues(string value)
    {
        string[] delimeters = GetDelimeters(value);

        if (value.StartsWith("//"))
        {
            value = value.Substring(3, value.Length - 3);
        }
        
        int result = 0;
        List<string> values = value.Split(delimeters, StringSplitOptions.None).ToList();
        foreach (var stringValue in values)
            result += int.Parse(stringValue);
        return result;
    }

    private static string[] GetDelimeters(string value)
    {
        if (value.StartsWith("//"))
            return new [] { value.Substring(2, value.Length - 2).Split('\n')[0] };
        return new [] { ",", "\n" };
    }
}