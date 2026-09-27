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
    public ListNode ReverseList(ListNode head) {
        ListNode tmp = head;
        ListNode prev = null;
        while (tmp != null) {
            var swapper = tmp;
            tmp = tmp.next;
            swapper.next = prev;
            prev = swapper;
        }
        return prev;
    }
}
