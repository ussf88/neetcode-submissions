public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int total = 1;
        int total0 = 0;
        int zIndex=-1;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0) total*=nums[i];
            else{
                total0++;
                zIndex= zIndex==-1 ? i : zIndex;
            }
        }
        var rez = new int [nums.Length];
        if(total0>1) return rez;
        if(total0==1){
            rez[zIndex] = total;
            return rez;
        }
        
        for(int i=0;i<nums.Length;i++){
            rez[i] = total/nums[i];
        }
        return rez;
    }
}
