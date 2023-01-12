namespace NumberConverterApp;
public class NumberConverter
{
    public string ConvertToNumeral(int number)
    {
        if (number < 0 || number > 2000)
        {
            return "Please enter a number between 1 - 2000";
        }

        SortedDictionary<int, string> numberToNumeral = new() {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
            {40, "XL"},
            {50, "L"},
            {90, "XC"},
            {100, "C"},
            {400, "CD"},
            {500, "D"},
            {900, "CM"},
            {1000, "M"}
        };

        string romanNumerals = "";

        foreach (int key in numberToNumeral.Keys.OrderByDescending(x => x))
        {
            while (number >= key)
            {
                number -= key;
                romanNumerals += (numberToNumeral[key]);
            }
        }

        return romanNumerals;
    }
}

