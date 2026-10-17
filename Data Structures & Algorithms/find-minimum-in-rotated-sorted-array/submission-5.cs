public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int l = 0, r = n - 1;
        if(nums[l]<nums[r] || n==1) return nums[l];
        while (l <= r) {
            int middle = l + (r - l) / 2;
            if (IsValidMiddle(nums, middle))
                return nums[middle];
            if (nums[middle] >= nums[0])
                l = middle + 1;
            else
                r = middle - 1;
        }
        return -1000;
    }

    private bool IsValidMiddle(int[] nums, int middle) {
        return middle != 0 && nums[middle] < nums[middle - 1];
    }
}
