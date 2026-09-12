public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new ();
        int n = nums.Length;
        for(int i=0;i<n;i++){
            if(set.Contains(nums[i])) return true;
            set.Add(nums[i]);
        }
        return false;
    }
}