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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 is null) return list2;
        if(list2 is null) return list1;
        var t1 = list1;
        var t2 = list2;
        ListNode t = null;
        var head = t1.val <= t2.val ? t1 : t2;

        do {
            if (t1 != null && (t2 is null || t1.val <= t2.val)) {
                if (t is not null)
                    t.next = t1;
                t = t1;
                t1 = t1.next;
            } else if (t2 != null && (t1 is null || t2.val < t1.val)) {
                if (t is not null)
                    t.next = t2;
                t = t2;
                t2 = t2.next;
            }
        } while (t1 != null || t2 != null);

        return head;
    }
}