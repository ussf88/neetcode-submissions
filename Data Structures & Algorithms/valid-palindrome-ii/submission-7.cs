public class Solution {
    public bool ValidPalindrome(string s) {
        int validRemovals = 1;
        int n = s.Length;  
        int i = 0, j = n - 1;
        while (i <= j) {
            if (s[i] != s[j]) validRemovals--;
            if (validRemovals == 0){

                return IsPalindrome(s,i+1,j) || IsPalindrome(s,i,j-1);

            }
            i++;
            j--;
        }
        return true;
    }
    private bool IsPalindrome(string s,int i,int j) {
        while(j>=i){
           if(s[i]!= s[j]) return false;
           i++;
            j--;
        }
       
        return true;
    }
}