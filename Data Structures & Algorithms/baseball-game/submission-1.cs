public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new();
        foreach(var c in operations){
            switch(c){
                case "+": {
                    var  last= stack.Pop();
                    var beforelast=stack.Peek();
                    stack.Push(last);
                    stack.Push(last+beforelast);
                    break;
                }
   
                case "D": stack.Push(stack.Peek()*2);break;
                case "C": stack.Pop();break;
                default: stack.Push(int.Parse(c));break;
            }

        }
        return stack.Sum();
    }
}