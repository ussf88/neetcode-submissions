public class Solution {
    public int CharacterReplacement(string s, int k) {
        int n = s.Length;
        if (n == 1)
            return 1;
        int left = 0, right = 1;
        int max = 1;
        int[] freq = new int[26];

        char mostFreq;
        mostFreq = s[0];
        freq[ToIndex(mostFreq)]++;

        int replacements = 0;

        while (right < n) {
            char currentLetter = s[right];
            freq[ToIndex(currentLetter)]++;
            if (freq[ToIndex(currentLetter)] > freq[ToIndex(mostFreq)])
                mostFreq = currentLetter;

            replacements = (right - left + 1) - freq[ToIndex(mostFreq)];

            if (replacements > k) {
                left++;
                freq[ToIndex(s[left - 1])]--;
            } else {
                max = Math.Max(max, right - left + 1);
            }

            right++;
        }
        return max;

        int ToIndex(char c) => c - 'A';
        
    }
}
