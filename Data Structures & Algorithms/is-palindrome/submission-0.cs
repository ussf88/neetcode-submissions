public class Solution {
    public bool IsPalindrome(string s) {
        int n = s.Length;
        int i=0,j=n-1;
        while(j>=i){
            if(!char.IsLetterOrDigit(s[i])){
                 i++;
                 continue;
            }
            if(!char.IsLetterOrDigit(s[j])){
                 j--;
                 continue;
            }
           if(char.ToUpper(s[i]) != char.ToUpper(s[j]) ) return false;
           i++;
            j--;
        }
        return true;
    }
}
