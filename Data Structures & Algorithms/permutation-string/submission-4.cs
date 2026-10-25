public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int n1 = s1.Length;
        int n2 = s2.Length;
        if(n2<n1) return false;
        int l = 0, r = n1 - 1;  // size of s1 window
        var s1Freq = GenerateFreq(s1);
        var permFreq = GenerateFreq(s2);
        while (r < n2) {
            if (IsPermutation()) return true;
            if (r == n2 - 1) return false;

            permFreq[s2[l]-'a'] --;
            l++;
            r++;
            permFreq[s2[r]-'a']++;
        }
        return false;

        int[] GenerateFreq(string s) {
            var rez = new int[26];
            for (int i = 0; i < n1; i++) {
                rez[s[i] - 'a']++;
            }
            return rez;
        }
        bool IsPermutation() {
            for (int i = 0; i < 26; i++) {
                if (permFreq[i] != s1Freq[i])
                    return false;
            }
            return true;
        }
    }
}