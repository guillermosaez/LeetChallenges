namespace LeetChallenges._2_AddTwoNumbers;

public class AddTwoNumbersTests
{
	public static IEnumerable<object[]> GetListNodes()
	{
		return new[]
		{
			new ListNode[] { new(2, new(4, new(3))), new(5, new(6, new(4))), new(7, new(0, new(8))) },
			new ListNode[] { new(), new(), new() },
			new ListNode[]
			{
				new(9, new(9, new(9, new(9, new(9, new(9, new(9))))))),
				new(9, new(9, new(9, new(9)))),
				new(8, new(9, new(9, new(9, new(0, new(0, new(0, new(1))))))))
			}
		};
	}

	[Theory]
	[MemberData(nameof(GetListNodes))]
	public void Correct(ListNode list1, ListNode list2, ListNode expectedResult)
	{
		Assert.Equal(expectedResult, AddTwoNumbers.Sum(list1, list2));
	}
}