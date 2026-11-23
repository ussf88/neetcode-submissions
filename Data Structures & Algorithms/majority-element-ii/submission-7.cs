public class Solution {
    public List<int> MajorityElement(int[] nums) {
       return nums.GroupBy(n=>n).Where(g=>g.Count()>nums.Length/3).Select(g=>g.Key).ToList();
    }
}