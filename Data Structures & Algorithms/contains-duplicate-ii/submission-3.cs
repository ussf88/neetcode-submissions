public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int n = nums.Length;
        int l = 0, r = 0;
        HashSet<int> set = new();
        set.Add(nums[l]);
        while (r < n-1) {
          r++;
          if(r-l>k){
            set.Remove(nums[l]);
            l++;
            
          } 
          if(set.Contains(nums[r])) return true;
          set.Add(nums[r]);

        }
        return false;
    }
}