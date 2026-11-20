public class Solution {
    public int MaxProfit(int[] prices) {

        int total=0;
        int n=prices.Length;
        int left=0,right=1;
        int profit=0;
        while(right<n){
            if(prices[right]>=prices[right-1]) right++;
            else {
                 profit = (prices[right-1]-prices[left]);
                total += profit >0 ? profit:0;
                left=right;
                right++;
            }
        }
         profit = (prices[right-1]-prices[left]);
        total += profit >0 ? profit:0;
        return total;
        //[7,1,5,3,6,4]
        //[1,2,3,4,5,6]
    }
}
