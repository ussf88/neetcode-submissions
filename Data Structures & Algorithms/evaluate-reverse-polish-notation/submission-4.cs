public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        int n = tokens.Length;
        string[] operators = ["+","-","*","/"];
        for(int i =0;i<n;i++){
            if(operators.Contains(tokens[i])) stack.Push(RunOp(stack,tokens[i]));
            else stack.Push(int.Parse(tokens[i]));
        }
        return stack.Pop();
    }
    private int RunOp(Stack<int> stack, string oper){
        var op1= stack.Pop(); 
        var op2= stack.Pop(); 
        return oper switch {
            "+" => op1 + op2,
            "-" => op2 - op1,
            "*" => op1 * op2,
            "/" => op2 / op1,
            _ => 0
        };
    
                       
    }
}
