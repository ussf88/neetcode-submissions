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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int i = n;
        
        head = ReverseList(head);
        if(n==1){
            head=head.next;
            return ReverseList(head);
        }
        var tmp = head;
        var prev = tmp;
        while(i>1){
            i--;
            prev=tmp;
            tmp = tmp.next;
        }
        prev.next = tmp.next;
        
        return ReverseList(head);


    }
    private ListNode ReverseList(ListNode head) {
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
