public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;

        List<List<int>> rez = new();
        HashSet<(int, int, int)> set = new();
        for (int i = 0; i < n; i++) {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            int target = -nums[i];
            int j = i + 1, k = n - 1;
            while (k > j) {
                if (nums[k] + nums[j] > target)
                    k--;
                else if (nums[k] + nums[j] < target) {
                    j++;
                    while (j<k && nums[j] == nums[j - 1]) {
                        j++;
                    }
                } else {
                    rez.Add(new(3) { nums[i], nums[j], nums[k] });
                    j++;
                    while (j<k && nums[j] == nums[j - 1]) {
                        j++;
                    }
                }
            }
        }
        return rez;
    }

}
