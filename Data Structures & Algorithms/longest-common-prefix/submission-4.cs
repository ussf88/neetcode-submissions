public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int n=strs.Length;
        
        Array.Sort(strs,(a,b)=>a.Length-b.Length);
        var smallestStr = strs[0];
        int currentMin=smallestStr.Length;
        for(int i=0;i<n;i++){
            int j=0;
            while(j<smallestStr.Length && smallestStr[j]==strs[i][j]) j++;
            currentMin= Math.Min(currentMin,j);
            if(currentMin==0) return "";
        }
        return smallestStr[0..currentMin];
    }
}