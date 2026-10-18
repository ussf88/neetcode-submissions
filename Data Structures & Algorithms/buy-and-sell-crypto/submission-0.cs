public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int l=0,r=1;
        int profit=0;
        while(r>l && r<n){
            profit = Math.Max(profit,prices[r]-prices[l]);
            if(prices[r]<prices[l]){
                l++;
                if(l==r) r++;
            } else {
                r++;
            }
            
        }
        return profit;
    }
}
