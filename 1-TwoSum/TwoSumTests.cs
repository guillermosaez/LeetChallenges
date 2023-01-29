namespace LeetChallenges._1_TwoSum;

public class TwoSumTests
{
	[Theory]
	[InlineData(null)]
	public void Numbers_Null(int[] numbers)
	{
		Assert.Throws<ArgumentNullException>(() => TwoSum.Execute(numbers, 0));
	}

	[Theory]
	[InlineData(new int[] { })]
	public void Numbers_Empty(int[] numbers)
	{
		Assert.Throws<ArgumentOutOfRangeException>(() => TwoSum.Execute(numbers, 0));
	}

	[Theory]
	[InlineData(new[] { 1 })]
	public void Numbers_Length_Less_2(int[] numbers)
	{
		Assert.Throws<ArgumentOutOfRangeException>(() => TwoSum.Execute(numbers, 0));
	}

	[Fact]
	public void Numbers_Length_More_Max()
	{
		int numbersMaxLength = (int)Math.Pow(10, 4);
		int[] numbers = Enumerable.Range(1, numbersMaxLength + 1).ToArray();
		Assert.Throws<ArgumentOutOfRangeException>(() => TwoSum.Execute(numbers, 0));
	}

	[Fact]
	public void Target_Value_Less_Lower_Limit()
	{
		int lowerLimit = -(int)Math.Pow(10, 9);
		Assert.Throws<ArgumentOutOfRangeException>(() => TwoSum.Execute(new[] { 1, 2 }, lowerLimit - 1));
	}

	[Fact]
	public void Target_Value_More_Higher_Limit()
	{
		int higherLimit = (int)Math.Pow(10, 9);
		Assert.Throws<ArgumentOutOfRangeException>(() => TwoSum.Execute(new[] { 1, 2 }, higherLimit + 1));
	}

	[Theory]
	[InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
	[InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
	[InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
	public void Correct(int[] numbers, int target, int[] expected)
	{
		int[] result = TwoSum.Execute(numbers, target);
		Assert.Equal(expected, result);
	}
}