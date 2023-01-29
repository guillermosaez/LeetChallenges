namespace LeetChallenges._1_TwoSum;

//https://leetcode.com/problems/two-sum/
public static class TwoSum
{
	public static int[] Execute(int[] numbers, int target)
	{
		ValidateNumbers(numbers);
		ValidateTarget(target);
		for (int i = 0; i < numbers.Length - 1; i++)
		{
			for (int j = i + 1; j < numbers.Length; j++)
			{
				if (numbers[i] + numbers[j] == target)
				{
					return new[] { i, j };
				}
			}
		}
		return null;
	}

	private static void ValidateNumbers(int[] numbers)
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

	private static void ValidateTarget(int target)
	{
		double limitValue = Math.Pow(10, 9);
		if (target > limitValue || target < -limitValue)
		{
			throw new ArgumentOutOfRangeException(nameof(target));
		}
	}
}