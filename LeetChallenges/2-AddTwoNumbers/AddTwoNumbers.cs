namespace LeetChallenges._2_AddTwoNumbers;

//https://leetcode.com/problems/add-two-numbers/
public static class AddTwoNumbers
{
	public static ListNode Sum(ListNode list1, ListNode list2)
	{
		//TODO: Validaciones
		int list1ReverseSumValue = CalculateReversedSumValue(list1);
		int list2ReverseSumValue = CalculateReversedSumValue(list2);
		int sum = list1ReverseSumValue + list2ReverseSumValue;

		List<int> sumValues = new();
		while (sum >= 10)
		{
			sumValues.Add(sum % 10);
			sum /= 10;
		}
		sumValues.Add(sum);

		sumValues.Reverse();
		ListNode resultNode = null;
		foreach (int value in sumValues)
		{
			resultNode = new(value, resultNode);
		}
		return resultNode;
	}

	private static int CalculateReversedSumValue(ListNode list)
	{
		int result = 0;
		int multiplier = 1;
		while (list != null)
		{
			result += list.Value * multiplier;
			multiplier *= 10;
			list = list.Next;
		}
		return result;
	}
}

public record ListNode(int Value = 0, ListNode? Next = null);