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
            List<ListNode> list = new();
            ListNode t = head;
            while (t is not null) {
                list.Add(t);
                t = t.next;
            }
            int lenght = list.Count;
            int i = 0, j = lenght - 1;
            Console.WriteLine(string.Join(",", list.Select(l => l.val)));
             while (i < j) {
                if (j < lenght - 1){
                    list[j + 1].next = list[i];
                    Console.WriteLine($"{list[j + 1].val} => {list[i].val}");
                } 
                list[i].next = list[j];
                Console.WriteLine($"{i} && {j}");
                i++;
                j--;
            }
           
            if(i!=j)list[i].next = null;
            else{
                list[j+1].next = list[i];
                list[i].next = null;
            } 
        } catch (Exception e) {
            Console.WriteLine($"{e.Message}");
        }
    }
}
