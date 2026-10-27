public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Length;
        int l = 0, r = 0;
        int sum = 0;
        int min = int.MaxValue;
        while (r < n) {
            sum += nums[r];
            while (sum >= target && l<=r) {
                sum -= nums[l];
                min = Math.Min(min, r - l + 1);
                l++;
            }
            r++;
            
        }
        return min == int.MaxValue ? 0 : min;
    }
}