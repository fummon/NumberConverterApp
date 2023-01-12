using NumberConverterApp;

namespace NumberConverterApp_Tests;

[TestClass]
public class NumberConverter_Tests
{
    private NumberConverter _converter;

    [TestInitialize]
    public void Init()
    {
        _converter = new(); 
    }

    [DataRow(1999, "MCMXCIX")]
    [DataRow(938, "CMXXXVIII")]
    [DataRow(439, "CDXXXIX")]
    [DataRow(92, "XCII")]
    [DataRow(34, "XXXIV")]
    [DataRow(12, "XII")]
    [DataRow(4, "IV")]
    [DataTestMethod]
    public void ConvertToNumeral_GivenValidNumber_ConvertsToRomanNumeral(int number, string numeral)
    {
        string result = _converter.ConvertToNumeral(number);
        result.Equals(numeral); 
    }

    [DataRow(2001)]
    [DataRow(-1)]
    [DataTestMethod]
    public void ConvertToNumeral_InvalidNumber_ReturnsErrorMessage(int number)
    {
        string expected = "Please enter a number between 1 - 2000";

        string result = _converter.ConvertToNumeral(number);
        result.Equals(expected);
    }
}
