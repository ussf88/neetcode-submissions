public class Solution {
    public int[] SortArray(int[] nums) {
        Rearrange(nums,0,nums.Length-1);
        return nums;
    }
    private void Rearrange(int[] arr,int start , int end) {
         if (start >= end) return;
        int pivot = arr[end];
        int pi = end;
        int i = start -1, current = start;
        while (current < end) {
            if (arr[current] <= pivot) {
                i++;
                Swap(i, current);
            }

            current++;
        }
        Swap(pi, i + 1);
        Rearrange(arr,start ,i);
        Rearrange(arr,i+2 ,end);
        return;
        void Swap(int a, int b) => (arr[a], arr[b]) = (arr[b], arr[a]);
    }
}