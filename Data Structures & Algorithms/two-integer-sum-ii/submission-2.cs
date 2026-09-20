public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i=0,j=numbers.Length-1;
        int sum = int.MinValue;
        while(sum != target ){
            sum = numbers[i]+numbers[j];
            if(sum >target) j--;
            if(sum<target) i++;
        }
        return [i+1,j+1];
    }
}
