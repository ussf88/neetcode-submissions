public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;

        List<List<int>> rez = new();

        for (int i = 0; i < n; i++) {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;  // every i handle everyhting after it , so subsequent i just skip them
            int target = -nums[i];
            int j = i + 1, k = n - 1;
            while (k > j) {
                if (nums[k] + nums[j] > target) {
                    k--;
                    continue;
                }
                
                if(nums[k] + nums[j] == target) rez.Add(new(3) { nums[i], nums[j], nums[k] });
                    
                
                j++;
                while (j < k && nums[j] == nums[j - 1]) {
                    j++;
                }
            }
        }
        return rez;
    }
}
