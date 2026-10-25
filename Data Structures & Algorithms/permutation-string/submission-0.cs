public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int n1 = s1.Length;
        int n2 = s2.Length;
        int l = 0, r = n1 - 1;  // size of s1 window
        var s1Freq = GenerateFreq(s1);
        while (r < n2) {
            if (IsPermutation(s2.Substring(l, r - l + 1)))
                return true;
            l++;
            r++;
        }
        return false;

        int[] GenerateFreq(string s) {
            var rez = new int[26];
            for (int i = 0; i < n1; i++) {
                rez[s[i] - 'a']++;
            }
            return rez;
        }
        bool IsPermutation(string perm) {
            var permFreq = GenerateFreq(perm);
            for (int i = 0; i < 26; i++) {
                if (permFreq[i] != s1Freq[i])
                    return false;
            }
            return true;
        }
    }
}
