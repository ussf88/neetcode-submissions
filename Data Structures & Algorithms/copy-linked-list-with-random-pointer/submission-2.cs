/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    private Dictionary<Node, Node> nodes = new();
    public Node copyRandomList(Node head) {
        Node copy = null;
        var tmp = head;
        while (tmp != null) {
            var clone = CloneNode(tmp);
            clone.next = tmp.next;
            tmp.next = clone;
            tmp=tmp.next?.next;
        }
        tmp = head;
        while(tmp!=null){
            if(tmp.random != null){
                tmp.next.random = tmp.random.next;
            }
            tmp=tmp.next?.next;
        }
        tmp = head;
        Node prev = null;
        while(tmp!=null){
            if(prev is null){
                 prev = tmp.next;
                 copy = prev;
            }
            else{ 
                prev.next=tmp.next;
                prev=prev.next;
            }
            tmp.next=tmp.next?.next; 
            tmp=tmp.next;

        }
       return copy;
    }
    private Node CloneNode(Node realNode) {
        return realNode != null ? new Node(realNode.val) : null;
    }
}
