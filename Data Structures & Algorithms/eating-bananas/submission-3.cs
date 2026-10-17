public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        Array.Sort(piles);
        int n = piles.Length;
        int maxPile = piles[n-1];
        //if(h==n) return maxPile;
        int l =1,r=maxPile;
        int rez=int.MaxValue;
        int middle = rez;
        while(l<r){
            middle = l+(r-l)/2;
            if(GetTotalTime(piles,middle)>h){
                l=middle+1;
            }
            else{
                r=middle;
                rez= Math.Min(rez,middle);
            }
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
