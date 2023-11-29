namespace Reverse_Linked_List;

internal class Program
{
    static void Main(string[] args)
    {
        ReverseList(new ListNode(1, new ListNode(2, new ListNode(3, null))));
    }
    public static ListNode? ReverseList(ListNode head)
    {
        var current = head;
        ListNode? previous = null;
        ListNode? next;

        while (current != null)
        {
            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }
}
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}
