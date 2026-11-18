public class MyHashMap {
    private const int n = 10_000;
    private Node?[] arr;
    public MyHashMap() {
        arr =  new Node[n];
    }
    
    public void Put(int key, int value) {
        int index = key % n;
        if(arr[index]==null){
            arr[index] = new Node(key,value);
            return;
        }
        var t = arr[index];
        while(t!.key != key && t.next != null) t=t.next;
        if(t.key == key){
            t.val=value;
            return;
        }
        t.next = new Node(key,value);
    }
    
    public int Get(int key) {
        int index = key % n;
        if(arr[index]==null) return -1;

        var t = arr[index];
        while(t.key != key && t.next != null) t=t.next;
        if(t.key == key) return t.val;
        return -1;
    }
    
    public void Remove(int key) {
        int index = key % n;
        if(arr[index]==null) return;
        var t = arr[index];
        Node? prev=null;
        while(t.key != key && t.next != null){
            prev=t;
            t=t.next;
        }

        if (prev == null)
        {
            arr[index] = t.next;
            return;
        }
        if(t.key == key) prev.next=t.next;
       
    }
    public record Node {
        public int key;
        public int val;
        public Node? next;
        public Node(int k , int v,Node? n=null)=> (key,val,next)=(k,v,n);
    }
}
