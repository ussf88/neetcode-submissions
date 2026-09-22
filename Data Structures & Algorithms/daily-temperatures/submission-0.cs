public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        var rez = new int[n];
        Stack<(int temp , int index)> stack = new(n);
        for(int i=0;i<n;i++){
            while( stack.Count>0 && stack.Peek().temp < temperatures[i]){
                var (temp,index) = stack.Pop();
                rez[index] = i - index;
            }
            stack.Push((temperatures[i],i));

        }
        return rez;
    }
}
