namespace LeetChallenges._13_RomanToInteger;

public class RomanToIntegerTests
{
    [Theory]
    [InlineData(null)]
    public void Input_Null_ArgumentNullException(string input)
    {
        Assert.Throws<ArgumentNullException>(() => RomanToInteger.Convert(input));
    }

    [Theory]
    [InlineData("")]
    public void Input_StringEmpty_ArgumentOutOfRangeException(string input)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => RomanToInteger.Convert(input));
    }

    [Theory]
    [InlineData("IIIIIIIIIIIIIIIIIIII")]
    public void Input_Longer_Than_15_ArgumentOutOfRangeException(string input)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => RomanToInteger.Convert(input));
    }

    [Theory]
    [InlineData("Z")]
    public void Input_InvalidCharacters_ArgumentException(string input)
    {
        Assert.Throws<ArgumentException>(() => RomanToInteger.Convert(input));
    }

    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void Input_Number_Correct(string input, int expected)
    {
        int value = RomanToInteger.Convert(input);
        Assert.Equal(expected, value);
    }
}