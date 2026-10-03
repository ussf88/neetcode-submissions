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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode t1=l1,t2=l2;
        ListNode rez =null;
        var t = rez;
        int rest = 0;
        while(t1 != null ||t2!=null){
            int a=0,b=0;
            if(t1!=null) a =t1.val;
            if(t2!=null) b =t2.val;
            int c = a+b+rest;
            var node = new ListNode(c);
            rest = 0;
            if(c>9){
                node = new ListNode(c%10);
                rest = 1;
            }
            
            if(rez == null){
                rez= node;
                t= node;
            }
            else{
                t.next=node;
                t=t.next;
            }
            t1=t1?.next;
            t2=t2?.next;
          
        }
        if (rest==1){
            t.next=new ListNode(1);
        }
        return rez;
    }
}
