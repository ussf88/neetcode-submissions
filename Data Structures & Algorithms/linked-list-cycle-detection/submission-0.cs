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
        HashSet<ListNode> rez = new();
        var t = head;
        while(t != null){
            if(!rez.Contains(t)) rez.Add(t);
            else return true;
            t = t.next;
        }
        return false;
    }
}
