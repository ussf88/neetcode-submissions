public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int l = 0, r = n - 1;
        while (l <= r) {
            int m = l + (r - l) / 2;
            if (target == nums[m])
                return m;
            if (nums[0] <= nums[m]) {
                // right oredred side
                if (target < nums[m] && target >= nums[0])
                    r = m - 1;
                else
                    l = m + 1;
            } else {
                if (target > nums[m] && target <= nums[n - 1])
                    l = m + 1;
                else
                    r = m - 1;
                // left ordered side
            }
        }
        return -1;
    }
}
