using System.Threading.Tasks.Sources;

namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string value)
    {
        if (value != "0")
            return int.Parse(value);
        return 0;
    }
}