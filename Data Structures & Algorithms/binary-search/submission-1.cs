public class Solution {
    public int Search(int[] nums, int target) {
        int left=0,right = nums.Length-1;
        int middle = 0;
        while(left<=right){
            middle = left + (right-left/2);
            if (nums[middle]> target) right=middle-1;
            else if(nums[middle]<target) left=middle+1;
            else return middle;
        }
        return -1;
    }
}
