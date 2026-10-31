public class MyHashSet {
    private Node[] arr;
    int n = 10_000;

    public MyHashSet() {
        arr = new Node[n];
    }

    public void Add(int key) {
        int index = key % n;
        var node = new Node(key, null);
        if (arr[index] is null) {
            arr[index] = node;
            return;
        }
        if(key==arr[index].val) return;
        Node tmp = arr[index];
        while (tmp.next != null) tmp = tmp.next;
        tmp.next = node;
    }

    public void Remove(int key) {
        int index = key % n;
        if(arr[index]==null) return;
        Node tmp = arr[index];
        Node prev = null;
        while ( tmp!=null && tmp.val != key){
            prev=tmp;
            tmp = tmp.next;
        } 
        if(tmp==null) return;
        if(prev==null) arr[index]=tmp.next;
        else prev.next=tmp.next;
    }

    public bool Contains(int key) {
        int index = key % n;
        if(arr[index]==null) return false;
        Node tmp = arr[index];
        while (tmp!=null && tmp.val != key){
            tmp = tmp.next;
        } 
        if(tmp==null) return false;
        return true;
    }
    class Node{
        public Node(int v,Node n)=>(val,next)=(v,n);
        public int val;
        public Node next;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */