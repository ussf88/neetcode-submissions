public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int n = piles.Length;
        int maxPile = piles.Max();
    
        int l =1,r=maxPile;
        int middle = 0;
        while(l<r){
            middle = l+(r-l)/2;
            if(GetTotalTime(piles,middle)>h)  l=middle+1;
            else r=middle;
            
        }
        return l;
        

    }
    private int GetTotalTime(int[] piles,int k){
        int total = 0;
        for(int i=0;i<piles.Length;i++){
            total+= (int)Math.Ceiling((double)piles[i]/(double)k);
        }
        return total;
    }
}
