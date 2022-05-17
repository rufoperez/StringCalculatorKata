using System.Threading.Tasks.Sources;

namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string value)
    {
        if (string.IsNullOrEmpty(value))
            return 0;
        if (value.IndexOf(',') > 0)
        {
            var result = 0;
            string[] values = value.Split(',');
            foreach (var val in values)
            {
                result += int.Parse(val);
            }

            return result;
        }
        return int.Parse(value);
    }
}