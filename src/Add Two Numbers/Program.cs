namespace AddTwoNumbers;

internal class Program
{
    static void Main(string[] args)
    {
        var result = AddTwoNumbers(
            //new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))),
            //new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))));
            //new ListNode(2, new ListNode(4, new ListNode(3))),
            //new ListNode(5, new ListNode(6, new ListNode(4))));
            new ListNode(0),
            new ListNode(7, new ListNode(3)));
    }
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carryNum = 0;
        var resultNode = new ListNode();
        var nextNode = resultNode;
        ListNode? currentNode1 = l1;
        ListNode? currentNode2 = l2;
        while (true)
        {
            if (currentNode1 is null && currentNode2 is null && carryNum == 0)
            {
                break;
            }

            int currentSum = (currentNode1 is null ? 0 : currentNode1.val) + (currentNode2 is null ? 0 : currentNode2.val);
            currentSum += carryNum;
            carryNum = 0;
            if (currentSum >= 10)
            {
                carryNum = 1;
                nextNode.val = currentSum - 10;
            }
            else
            {
                nextNode.val = currentSum;
            }

            if (currentNode1 is null && currentNode2 is null)
            {
                break;
            }

            if (currentNode1 is null && currentNode2.next != null)
            {
                nextNode.next = new ListNode();
                nextNode = nextNode.next;
            }
            else if (currentNode2 is null && currentNode1.next != null)
            {
                nextNode.next = new ListNode();
                nextNode = nextNode.next;
            }
            else if (carryNum > 0)
            {
                nextNode.next = new ListNode();
                nextNode = nextNode.next;
            }
            else {
                var added = false;
                if (currentNode1 != null && !added)
                {
                    if (currentNode1.next != null)
                    {
                        nextNode.next = new ListNode();
                        nextNode = nextNode.next;
                        added = true;
                    }
                }
                if (currentNode2 != null && !added)
                {
                    if (currentNode2.next != null)
                    {
                        nextNode.next = new ListNode();
                        nextNode = nextNode.next;
                        added = true;
                    }
                }
            }


            if (currentNode1 != null)
            {
                currentNode1 = currentNode1.next;
            }

            if (currentNode2 != null)
            {
                currentNode2 = currentNode2.next;
            }
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