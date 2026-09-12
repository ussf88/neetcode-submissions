public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new();
        int n = nums.Length;
        for(int i=0;i<n;i++){
            if(dict.ContainsKey(nums[i])) return [dict[nums[i]],i];
            int complement = target - nums[i];
            dict[complement] = i;
        }
        return [-1,-1];
    }
}
