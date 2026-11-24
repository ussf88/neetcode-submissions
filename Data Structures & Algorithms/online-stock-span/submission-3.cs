public class StockSpanner {
    private Stack<Node> stack;
    public StockSpanner() {
        stack = new();
    }

    public int Next(int price) {
        var node = new Node(price, 1);
        if (stack.Count == 0 || stack.Peek().val > price) {
            stack.Push(node);
            return 1;
        }
        // bigger price
        int span = 1;
        while (stack.Count > 0 && stack.Peek().val <= price) {
            span += stack.Pop().count;
        }
        node = new Node(price, span);
        stack.Push(node);

        return span;
    }

    public struct Node {
        public int val;
        public int count;
        public Node(int v, int c) => (val, count) = (v, c);
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */