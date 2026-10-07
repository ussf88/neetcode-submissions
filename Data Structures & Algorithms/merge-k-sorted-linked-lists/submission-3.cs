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
    public ListNode MergeKLists(ListNode[] lists) {
        var pq = new PriorityQueue<ListNode, int>();
        var k = lists.Length;
        ListNode head = null;
        for (var i = 0; i < k; i++){
            if(lists[i]==null) continue;
            pq.Enqueue(lists[i], lists[i].val);
        }
        ListNode prev = null;
        while (pq.TryDequeue(out var node, out var priority)) {
            if (node.next != null)
                pq.Enqueue(node.next, node.next.val);

            if (head == null) {
                head = prev = node;
                continue;
            }

            prev.next = node;
            prev = node;
        }

        return head;
    }
}
