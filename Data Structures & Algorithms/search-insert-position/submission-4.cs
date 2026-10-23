public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int n= nums.Length;
        int l=0,r=n-1;
        int m=0;
        while(l<=r){
            
            m=l+(r-l)/2;
            Console.WriteLine($" {l} ..{r} => {m}");
            if(nums[m]==target) return m;
            if(nums[m]<target) l=m+1;
            else r=m-1;
        }
        Console.WriteLine($" {l} ..{r}");
        return nums[m]>target ? Math.Max(m,0) : m+1;
    }
}