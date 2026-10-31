public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        int n=nums.Length;
        int count=0;
        int i=0;
        while(i<n && count<n/2){
            if(i==0 || nums[i]!=nums[i-1]){
                count=0;
            }
            count++;
            i++;
        }
        return nums[i];
    }
}