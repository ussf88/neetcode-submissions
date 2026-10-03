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
    private Dictionary<Node,Node> nodes = new();
    public Node copyRandomList(Node head) {
        Node copy=null;
        var tmp=head;
        Node tmpc=null;
        while(tmp != null){
            tmpc = GetOrCreateCopyNode(tmp);
            if(copy == null) copy=tmpc;
            if(tmp.random != null){
                var random = GetOrCreateCopyNode(tmp.random);
                tmpc.random = random;
            }
            tmp=tmp.next;
            tmpc.next=GetOrCreateCopyNode(tmp);
            tmpc=tmpc.next;
        }
        return copy;
    }
    private Node GetOrCreateCopyNode(Node realNode){
        if(realNode is null) return null;
        if(!nodes.ContainsKey(realNode)){
            var copyNode = new Node(realNode.val);
            nodes[realNode]=copyNode;
        } 
        return nodes[realNode];
    }
}
