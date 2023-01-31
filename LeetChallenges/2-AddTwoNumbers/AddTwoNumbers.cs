namespace LeetChallenges._2_AddTwoNumbers;

//https://leetcode.com/problems/add-two-numbers/
public static class AddTwoNumbers
{
    public static ListNode Sum(ListNode list1, ListNode list2)
    {
        Validate(list1);
        Validate(list2);

        int list1ReverseSumValue = CalculateReversedSumValue(list1);
        int list2ReverseSumValue = CalculateReversedSumValue(list2);
        int sum = list1ReverseSumValue + list2ReverseSumValue;

        Stack<int> sumValues = new();
        do
        {
            sumValues.Push(sum % 10);
            sum /= 10;
        } while (sum > 0);
        
        ListNode resultNode = null;
        while (sumValues.TryPop(out int value))
        {
            resultNode = new(value, resultNode);
        }
        return resultNode;
    }

    private static void Validate(ListNode listNode)
    {
        byte numberOfNodes = 1;
        ValidateValue(listNode);
        while (listNode.Next != null)
        {
            numberOfNodes++;
            if (numberOfNodes > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(listNode));
            }
            listNode = listNode.Next;
            ValidateValue(listNode);
        }
    }

    private static void ValidateValue(ListNode listNode)
    {
        if (listNode.Value is < 0 or > 9)
        {
            throw new ArgumentOutOfRangeException(nameof(ListNode.Value));
        }
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