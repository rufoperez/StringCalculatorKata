using System.Threading.Tasks.Sources;

namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string value)
    {
        var isOneNumber = value.Length == 1;

        if (string.IsNullOrEmpty(value))
            return 0;
        if(isOneNumber)
            return int.Parse(value);
        return SumStringValues(value);
    }

    private static int SumStringValues(string value)
    {
        int result = 0;
        List<string> values = value.Split(',').ToList();
        foreach (var stringValue in values)
            result += int.Parse(stringValue);
        return result;
    }
}