public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n=nums.Length;
        int j=1,i=0;
        while(j<n){
            if(nums[j]>nums[i]) nums[++i]=nums[j];
            j++;
        }
        return i+1;
    }
}