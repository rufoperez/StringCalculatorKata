using System.Threading.Tasks.Sources;

namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string value)
    {
        if (string.IsNullOrEmpty(value))
            return 0;
        if (value.IndexOf(',') > 0)
            return int.Parse(value.Split(',')[0]) + int.Parse(value.Split(',')[1]);
        return int.Parse(value);
    }
}