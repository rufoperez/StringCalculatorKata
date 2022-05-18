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
            var delimeters = GetSeparators(value);

            if (value.StartsWith("//"))
            {
                value = value.Substring(value.IndexOf("\n") + 1, value.Length - value.IndexOf("\n")-1);
            }

            return SumValues(value, delimeters);
        }
        CheckNegativeValue(value);
        return ConvertValueToInt(value);
    }

    private static string[] GetSeparators(string value)
    {
        string[] delimeters = null;
        if (value.StartsWith("//"))
        {
            bool hasMulticharDelimeters = value.IndexOf("[") > 0;
            if (hasMulticharDelimeters)
                return new string[1] {value.Substring(value.IndexOf("[") + 1, value.IndexOf("]") - value.IndexOf("[") - 1) };
            return new string[1] {value.Substring(2, 1)};
        }

        return new string[2] {",", "\n"};

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