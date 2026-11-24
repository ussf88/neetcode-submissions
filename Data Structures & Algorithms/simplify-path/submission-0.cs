public class Solution {
    public string SimplifyPath(string path) {
        var arr = path.Split('/',StringSplitOptions.RemoveEmptyEntries);
        var stack = new Stack<string>();
        stack.Push("");
        foreach(var folder in arr){
            if(folder == ".") continue;
            if(folder == ".."){ 
                if(stack.Count>1) stack.Pop();
                continue;
            }
            stack.Push(folder);
        }
        return stack.Count==1 ? "/" : string.Join("/",stack.Reverse());
    }
}