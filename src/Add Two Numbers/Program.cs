namespace AddTwoNumbers;

internal class Program
{
    static void Main(string[] args)
    {
        var result = AddTwoNumbers(
            new ListNode(2, new ListNode(4, new ListNode(3))),
            new ListNode(5, new ListNode(6, new ListNode(4))));
    }
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carryNum = 0;
        var resultNode = new ListNode();
        var nextNode = resultNode;
        var currentNode1 = l1;
        var currentNode2 = l2;
        while (currentNode1 != null || currentNode2 != null)
        {
            int currentSum = (currentNode1 is null ? 0 : currentNode1.val) + (currentNode2 is null ? 0 : currentNode2.val);
            currentSum += carryNum;
            if (currentSum >= 10)
            {
                carryNum = 1;
                nextNode.val = currentSum - 10;
            }
            else
            {
                nextNode.val = currentSum;
            }
            nextNode.next = new ListNode();
            nextNode = nextNode.next;

            currentNode1 = currentNode1.next;
            currentNode2 = currentNode2.next;
        }

        return resultNode;
    }
}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}