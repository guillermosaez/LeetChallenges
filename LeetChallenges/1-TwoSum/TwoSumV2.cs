namespace LeetChallenges._1_TwoSum;

public static class TwoSumV2
{
    public static int[] Execute(int[] numbers, int target)
    {
        TwoSumValidations.ValidateNumbers(numbers);
        TwoSumValidations.ValidateTarget(target);

        Dictionary<int, ComplementAndIndex> numberComplements = new();
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            int complement = target - currentNumber;
            if (numberComplements.TryGetValue(complement, out ComplementAndIndex anotherComplement))
            {
                if (currentNumber == anotherComplement.complement)
                {
                    return new[] { anotherComplement.index, i };
                }
            }
            numberComplements.TryAdd(currentNumber, new(i, complement));
        }
        return null;
    }

    private record struct ComplementAndIndex(int index, int complement);
}