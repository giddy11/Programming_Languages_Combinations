// See https://aka.ms/new-console-template for more information


//var list1 = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, null)))));
var list1 = new ListNode(1, new ListNode(1, new ListNode(2, null)));
var sol = new Solution();
sol.DeleteDuplicates(list1);


public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var newNode = new ListNode(-1, null);
        newNode.next = head;
        var ptr = newNode;

        for (; head != null && head.next != null; ptr = ptr.next)
        {
            if (head.val != head.next.val)
            {
                ptr.next = head;
            }
            else
            {
                ptr.next = ptr;
            }
            head = head.next;
        }
        if (head != null)
            ptr.next = head;


        return newNode.next;
    }
}

public class ListNode
{
    public ListNode(int val, ListNode next)
    {
        this.val = val;
        this.next = next;
    }

    public int val;
    public ListNode next;
}