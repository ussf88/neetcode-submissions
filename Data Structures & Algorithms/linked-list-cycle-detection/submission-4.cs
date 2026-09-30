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
    public bool HasCycle(ListNode head) {
        var slow = head;
        var fast = head;
        while(fast !=null){
            
            if((fast=fast.next)==slow) return true;
            if((fast=fast?.next)==slow) return true;
            slow = slow.next;
        }
        return false;
    }
}
