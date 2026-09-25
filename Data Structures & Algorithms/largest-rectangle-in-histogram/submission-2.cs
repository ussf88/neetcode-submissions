public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length;
        Stack<int> stack = new();
        Stack<int> stackl = new();
        var rightBoundries = new int [n];
        var leftBoundries = new int [n];
        for(int i=0;i<n;i++){
            while(stack.Count>0 && heights[stack.Peek()]>heights[i]){
                var t = stack.Pop();
                rightBoundries[t] = i-1;
            }
            stack.Push(i);
        }
        while(stack.Count>0){
            var t = stack.Pop();
            rightBoundries[t] =  n-1;
        }
        for(int i=n-1;i>=0;i--){
            while(stackl.Count>0 && heights[stackl.Peek()]>heights[i]){
                var t = stackl.Pop();
                leftBoundries[t] = i+1;
            }
            stackl.Push(i);
        }
        int max = 0;
        for(int i=0;i<n;i++){
            int h = (rightBoundries[i] - leftBoundries[i] +1 )*heights[i];
            max = Math.Max(h,max);
        }
    

        
        return max;
    }
}
