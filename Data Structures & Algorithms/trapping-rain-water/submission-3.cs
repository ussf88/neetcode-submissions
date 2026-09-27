public class Solution {
    public int Trap(int[] height) {
        int total = 0;
        int i=0,j=1;
        int n= height.Length;
        int current=0;
        while(j<n){

            if(height[j]<height[i]){
                 current += height[i] - height[j];
                 j++;
                 continue;
            }
            total += current;
            current=0;
            i=j;
            j++;
        }
        int k=i;
        i=n-1;j=n-2;current=0;
        
         while(j>=k){

            if(height[j]<height[i]){
                 current += height[i] - height[j];
                 j--;
                 continue;
            }
            total += current;
            current=0;
            i=j;
            j--;
        }
        return total;
    }
}
