// See https://aka.ms/new-console-template for more information

var list1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
var list2 = new ListNode(0, new ListNode(3, new ListNode(5, null)));
var sol = new Solution();
sol.MergeTwoLists(list1, list2);


public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var newListNode = new ListNode(-1, null);
        var currentHead = newListNode;
        var count_1 = 0;
        var count_2 = 0;

        for (; list1 != null && list2 != null; currentHead = currentHead.next)
        {
            if (list1.val <= list2.val)
            {
                currentHead.next = list1;
                list1 = list1.next;
                count_1++;
            }
            else
            {
                currentHead.next = list2;
                list2 = list2.next;
                count_2++;
            }
        }

        if (list1 != null)
            currentHead.next = list1;
        else
            currentHead.next = list2;

        GC.Collect();
        return newListNode.next;
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

