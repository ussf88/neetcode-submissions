public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0) return 0;
        Array.Sort(nums);
        int longest = 1;
        int currentLongest = 1;
        int i=0;
        while(i<nums.Length-1){
            int diff = nums[i+1]-nums[i];
        if(nums[i+1]-nums[i]<=1) currentLongest+=diff;
       
        else{
             longest = Math.Max(longest,currentLongest);
             currentLongest =1;

        }
        i++;
        }
        return Math.Max(longest,currentLongest);
    }
}
