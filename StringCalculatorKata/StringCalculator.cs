using System.Threading.Tasks.Sources;

namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string value)
    {
        if (string.IsNullOrEmpty(value))
            return 0;
        if (ValueHasSeparators(value))
        {
            var separators = GetSeparators(value);

            if (value.StartsWith("//"))
            {
                value = value.Substring(4, value.Length - 4);
            }

            return SumValues(value, separators);
        }
        CheckNegativeValue(value);
        return ConvertValueToInt(value);
    }

    private static string[] GetSeparators(string value)
    {
        string[] separators = null;
        if (value.StartsWith("//"))
        {
            separators = new string[1] {value.Substring(2, 1)};
        }
        else
        {
            separators = new string[2] {",", "\n"};
        }

        return separators;
    }

    private static bool ValueHasSeparators(string value)
    {
        return value.IndexOf(",") > 0 || value.IndexOf("\n") > 0 || value.StartsWith("//");
    }

    private static int ConvertValueToInt(string value)
    {
        if(int.Parse(value)> 1000)
            return 0;
        return int.Parse(value);
    }

    private static int SumValues(string value, string[] separators)
    {
        var result = 0;
        string[] values = value.Split(separators, StringSplitOptions.None);
        foreach (var val in values)
        {
            CheckNegativeValue(val);
            result += ConvertValueToInt(val);
        }

        return result;
    }

    private static void CheckNegativeValue(string val)
    {
        if (int.Parse(val) < 0)
            throw new ArgumentException("negatives not allowed");
    }
}