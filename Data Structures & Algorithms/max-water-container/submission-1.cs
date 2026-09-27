public class Solution {
    public int MaxArea(int[] heights) {
        int n= heights.Length;
        int l=0,r=n-1;
        int current=0;
        int a=0,b=0;
        while(l<r){
            current = Math.Max(current,(r-l)*Math.Min(heights[l],heights[r]));
            a=heights[r];
            b=heights[l];
            if(a>=b) l++;
            if(b>=a) r--;
        }
        return current;
    }
}
