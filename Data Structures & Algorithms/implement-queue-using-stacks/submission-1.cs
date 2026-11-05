public class MyQueue {
    private Stack<int> stackmain;
    private Stack<int> stack;
    public MyQueue() {
        stack= new();
        stackmain=new();
    }
    
    public void Push(int x) {
        while(stackmain.Count>0){
            stack.Push(stackmain.Pop());
        }
        stackmain.Push(x);
        while(stack.Count>0){
            stackmain.Push(stack.Pop());
        }
     
    }
    
    public int Pop() {
        return stackmain.Pop();
    }
    
    public int Peek() {
        return stackmain.Peek();
    }
    
    public bool Empty() {
        return stackmain.Count==0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */