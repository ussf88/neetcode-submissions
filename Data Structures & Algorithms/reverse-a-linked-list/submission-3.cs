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
        ListNode prev=null;

        while(tmp!= null){
            if(tmp.next == null){
                tmp.next=prev;
                prev=tmp;
                break;
            }
            var next = tmp.next;
            var current =  tmp;
            tmp = next.next;
            next.next = current;
            current.next=prev;
            prev= next;
        }
        return prev;
    }
}
