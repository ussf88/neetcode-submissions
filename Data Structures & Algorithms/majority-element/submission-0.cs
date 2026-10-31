public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        int n=nums.Length;
        int count=0;
        for(int i=0;i<n;i++){
            if(i==0 || nums[i]!=nums[i-1]){
                count=0;
            }
            count++;
            if(count>n/2) return nums[i];
        }
        return -1;
    }
}