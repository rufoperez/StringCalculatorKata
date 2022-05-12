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
        return int.Parse(value.Split(',')[0]) + int.Parse(value.Split(',')[1]);
    }
}