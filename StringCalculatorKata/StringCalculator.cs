using System.Threading.Tasks.Sources;

namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string value)
    {
        if (string.IsNullOrEmpty(value))
            return 0;
        if (value.IndexOf(",") > 0 || value.IndexOf("\n") > 0)
        {
            string[] separators = new string[2] {",", "\n"};

            var result = 0;
            string[] values = value.Split(separators, StringSplitOptions.None);
            foreach (var val in values)
            {
                result += int.Parse(val);
            }

            return result;
        }
        return int.Parse(value);
    }
}