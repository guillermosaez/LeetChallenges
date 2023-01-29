namespace LeetChallenges._1_TwoSum;

public static class TwoSumValidations
{
	public static void ValidateNumbers(int[] numbers)
	{
		if (numbers == null)
		{
			throw new ArgumentNullException(nameof(numbers));
		}
		if (numbers.Length < 2 || numbers.Length > Math.Pow(10, 4))
		{
			throw new ArgumentOutOfRangeException(nameof(numbers));
		}
	}

	public static void ValidateTarget(int target)
	{
		double limitValue = Math.Pow(10, 9);
		if (target > limitValue || target < -limitValue)
		{
			throw new ArgumentOutOfRangeException(nameof(target));
		}
	}
}