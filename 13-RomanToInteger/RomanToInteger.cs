namespace LeetChallenges._13_RomanToInteger;

//https://leetcode.com/problems/roman-to-integer/
public static class RomanToInteger
{
    private static readonly IDictionary<char, int> TRANSLATION_VALUES = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    public static int Convert(string input)
    {
        Validate(input);

        int result = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            char currentLetter = input[i];
            int currentValue = TRANSLATION_VALUES[currentLetter];

            bool existsLetterToRight = i < input.Length - 1;
            if (existsLetterToRight)
            {
                char letterToRight = input[i + 1];
                if (IsSubstraction(currentLetter, letterToRight))
                {
                    currentValue *= -1;
                }
            }
            result += currentValue;
        }
        return result;
    }

    private static void Validate(string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }
        if (input is { Length: < 1 or > 15 })
        {
            throw new ArgumentOutOfRangeException(nameof(input));
        }
        bool inputContainsNotValidLetter = input.Select(x => x).Except(TRANSLATION_VALUES.Keys).Any();
        if (inputContainsNotValidLetter)
        {
            throw new ArgumentException($"Input parameter contains any not valid character. Only {string.Join(',', TRANSLATION_VALUES.Keys)} are valid.", nameof(input));
        }
    }

    private static bool IsSubstraction(char current, char following)
    {
        return (current, following) switch
        {
            ('I', 'V' or 'X') => true,
            ('X', 'L' or 'C') => true,
            ('C', 'D' or 'M') => true,
            _ => false
        };
    }
}