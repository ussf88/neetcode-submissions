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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
    if (left == right) return head;
    var t = head;
    ListNode prevLeft = null;
    ListNode nextRight = null;
    var leftNode = t;
    var rightNode = t;
    int i = 1;
    while (t != null && i < right) {
        if (i < left) prevLeft = t;
        if (i == left) leftNode = t;
        t = t.next;
        i++;
    }
    rightNode = t;
    nextRight = rightNode.next;
    
    ReverseList(leftNode, rightNode);
    leftNode.next = nextRight;
    if (prevLeft != null) {
        prevLeft.next = rightNode;
        return head;
    }

    return rightNode;
}
    private ListNode ReverseList(ListNode head, ListNode tail) {
        ListNode tmp = head;
        ListNode prev = null;
        var end = tail.next;
        while (tmp != end) {
            var swapper = tmp;
            tmp = tmp.next;
            swapper.next = prev;
            prev = swapper;
        }
        return prev;
    }
}