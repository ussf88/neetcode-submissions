public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
  

        List<List<int>> rez = new();
        HashSet<(int,int,int)> set = new();
        for (int i = 0; i < n; i++) {
            int target = - nums[i];
            int j=0,k=n-1;
            while(k>j){
                if(j!=i && k!=i){
                    if(nums[k] + nums[j] > target) k--;
                    else if(nums[k] + nums[j] < target) j++;
                    else{
                        var item =  NormalizeTuple((nums[i],nums[j],nums[k]));
                        if(!set.Contains(item)){
                             rez.Add(new(3){nums[i],nums[j],nums[k]});
                             set.Add(item);
                        }
                        k--;
                      
                    } 
                }
                else if (i==j) j++;
                else k--;

            }
        }
        return rez;
    }
    private (int,int,int) NormalizeTuple((int a,int b,int c) t){
        var ( a, b, c) = t;
        int max = Math.Max(a,Math.Max(b,c));
        int min = Math.Min(a,Math.Min(b,c));
        int rest = a+b+c-max-min;
        return (max,rest,min);

    }


}
