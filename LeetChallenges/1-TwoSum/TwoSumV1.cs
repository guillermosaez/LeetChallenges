namespace LeetChallenges._1_TwoSum;

//https://leetcode.com/problems/two-sum/
public static class TwoSumV1
{
	public static int[] Execute(int[] numbers, int target)
	{
		TwoSumValidations.ValidateNumbers(numbers);
		TwoSumValidations.ValidateTarget(target);
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
}