public class Solution {
    public bool IsValid(string s) {
        var dict = new Dictionary<char,char>(){
            ['{'] =  '}',
            ['['] =  ']',
            ['('] =  ')',
        };
        var arr = s.ToCharArray();
        int n= arr.Length;
        var stack = new Stack<char>();
        for(int i=0;i<n;i++){
            if(dict.ContainsKey(arr[i])) stack.Push(arr[i]);
            else if (stack.Count ==0 || dict[stack.Pop()] != arr[i]) return false;
        }
        return stack.Count==0;
    }
}
