public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n1=word1.Length;
        int n2=word2.Length;
        int i=0,j=0;
        StringBuilder sb = new();
        while(i<n1 || j<n2){
            if(i<n1){
                 sb.Append(word1[i]);
                 i++;
            }
            if(j<n2){ 
                sb.Append(word2[j]);
                j++;
            }
        }
        return sb.ToString();
    }
}