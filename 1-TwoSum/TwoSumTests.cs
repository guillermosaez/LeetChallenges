namespace LeetChallenges._1_TwoSum;

public class TwoSumTests
{
	[Theory]
	[InlineData(null, typeof(ArgumentNullException))]
	[InlineData(new int[] { }, typeof(ArgumentOutOfRangeException))]
	[InlineData(new[] { 1 }, typeof(ArgumentOutOfRangeException))]
	[MemberData(nameof(GetNumbersMaxLength))]
	public void Numbers_Null(int[] numbers, Type exceptionType)
	{
		Action testCode = () => TwoSumValidations.ValidateNumbers(numbers);
		Exception? exception = Record.Exception(testCode);
		Assert.IsType(exceptionType, exception);
	}

	public static IEnumerable<object[]> GetNumbersMaxLength()
	{
		int numbersMaxLength = (int)Math.Pow(10, 4);
		return new[]
		{
			new object[] { Enumerable.Range(1, numbersMaxLength + 1).ToArray(), typeof(ArgumentOutOfRangeException) }
		};
	}

	[Theory]
	[MemberData(nameof(GetTargetLimits))]
	public void Target_Limits(int target, Type exceptionType)
	{
		Action testCode = () => TwoSumValidations.ValidateTarget(target);
		Exception? exception = Record.Exception(testCode);
		Assert.IsType(exceptionType, exception);
	}

	public static IEnumerable<object[]> GetTargetLimits()
	{
		int higherLimit = (int)Math.Pow(10, 9);
		int lowerLimit = higherLimit * -1;
		return new[]
		{
			new object[] { higherLimit + 1, typeof(ArgumentOutOfRangeException) },
			new object[] { lowerLimit - 1, typeof(ArgumentOutOfRangeException) }
		};
	}

	[Theory]
	[InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
	[InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
	[InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
	public void V1Correct(int[] numbers, int target, int[] expected)
	{
		int[] result = TwoSumV1.Execute(numbers, target);
		Assert.Equal(expected, result);
	}
}