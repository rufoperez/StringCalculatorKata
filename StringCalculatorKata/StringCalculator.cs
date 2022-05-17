using System.Threading.Tasks.Sources;

namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string value)
    {
        if (value == "1")
            return 1;
        return 0;
    }
}