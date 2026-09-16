/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public void ReorderList(ListNode head) {
        try {
            if(head.next is null) return;
            List<ListNode> list = new();
            ListNode t = head;
            while (t is not null) {
                list.Add(t);
                t = t.next;
            }
            int lenght = list.Count;
            int i = 0, j = lenght - 1;
            while (i < j) {
                if (j < lenght - 1)
                    list[j + 1].next = list[i];
                list[i].next = list[j];
                i++;
                j--;
            }

            if (i == j)
                list[j + 1].next = list[i];

            list[i].next = null;

        } catch (Exception e) {
            throw;
        }
    }
}
