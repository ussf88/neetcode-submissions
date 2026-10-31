public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int n=nums.Length;
        int j=n-1;
        int count=0;
        int i = 0;
        while(i<=j){
            if(nums[i]==val){
                
                while(j>i && nums[j]==val) j--;
                (nums[i],nums[j])=(nums[j],nums[i]);
                count = i==j ? count : count+1;
            }
            else count++;
            i++;
        }
        Console.WriteLine(string.Join(",",nums));
        return count;
    }
}