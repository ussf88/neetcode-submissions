public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var n = nums.Length;
        int[] prefixSum = new int[n];
        Dictionary<int, int> TotalByPrefix = new();
        prefixSum[0] = nums[0];
        int total = 0;
        for (int i = 1; i < n; i++) {
            prefixSum[i] = prefixSum[i - 1] + nums[i];
        }

        TotalByPrefix[0] = 1;
        for (int i = 0; i < n; i++) {
            int requiredPrefix = prefixSum[i] - k;
            if (TotalByPrefix.ContainsKey(requiredPrefix)) {
                total += TotalByPrefix[requiredPrefix];
            }
            if (TotalByPrefix.ContainsKey(prefixSum[i]))
                TotalByPrefix[prefixSum[i]]++;
            else
                TotalByPrefix[prefixSum[i]] = 1;
        }
        //Print(prefixSum);
        return total;

        //[2,1, 2,4]

        //[2,-1,1,2]
    }
}