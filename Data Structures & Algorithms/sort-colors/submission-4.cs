public class Solution {
    public void SortColors(int[] nums) {
        int n = nums.Length;
        int i = -1, j = n, current = 0;
        while (current < Math.Min(j, n )) {
            if (current <= i) {
                current++;
                continue;
            }
            if (nums[current] == 0) {
                i++;
                Swap(i, current);

            } else if (nums[current] == 2) {
                j--;
                Swap(j, current);
            }
            if (nums[current] == 1)
                current++;
        }

        return;
        void Swap(int a, int b) => (nums[a], nums[b]) = (nums[b], nums[a]);
    }
}