using System.Threading.Tasks.Sources;

namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string value)
    {
        if (string.IsNullOrEmpty(value))
            return 0;
        if (ValueHasDelimeters(value))
        {
            var delimeters = GetDelimeters(value);
            value = GetValuesToSum(value);
            return SumValues(value, delimeters);
        }
        CheckNegativeValue(value);
        return ConvertValueToInt(value);
    }

    private static string GetValuesToSum(string value)
    {
        if (value.StartsWith("//"))
            return value.Split(new char[] {'\n'})[1];

        return value;
    }

    private static string[] GetDelimeters(string value)
    {
        if (value.StartsWith("//"))
            return GetMultipleDelimeters(value);

        return new string[] {",", "\n"};
    }

    private static string[] GetMultipleDelimeters(string value)
    {
        string delimeters = value.Substring(2, value.IndexOf('\n')-2);
        return delimeters.Split(new String[] {"[", "][", "]"}, StringSplitOptions.None);
    }

    private static bool ValueHasDelimeters(string value)
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