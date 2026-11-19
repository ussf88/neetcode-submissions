public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        List<int> res = new();

        int k = n / 3;
        Array.Sort(nums);
        int currentCount = 0;
        int currentElement=0;
        for (int i = 0; i < n; i++) {
            if (i == 0) currentElement = nums[i];
            if (nums[i] == currentElement)
                currentCount++;
            else{
                currentCount = 1;
                currentElement = nums[i];
            }
            if (currentCount > k) {
                res.Add(nums[i]);
                while (i < n - 1 && nums[i] == nums[i + 1]) i++;
            }
        }

        return res;
    }
}