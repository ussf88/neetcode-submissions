public class Solution {
    public int FirstMissingPositive(int[] nums) {
        Array.Sort(nums);
        int i=0;
        int n=nums.Length;
        while(i<n && nums[i]<=0) i++;
        if(i==n) return 1;
        int current=1;
        for(int j=i;j<n;j++){
            if(nums[j]==current) current++;
        }
        return current;
    }
}