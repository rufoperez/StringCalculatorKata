using System.Threading.Tasks.Sources;

namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string value)
    {
        if (string.IsNullOrEmpty(value))
            return 0;
        return int.Parse(value);
    }
}