public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n1=word1.Length;
        int n2=word2.Length;
        int i=0;
        StringBuilder sb = new();
        while(i< Math.Max(n1,n2)){
            if(i<n1)sb.Append(word1[i]);

            if(i<n2)sb.Append(word2[i]);
            i++;
        }
        return sb.ToString();
    }
}