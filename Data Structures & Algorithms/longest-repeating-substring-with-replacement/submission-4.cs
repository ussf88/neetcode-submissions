public class Solution {
    public int CharacterReplacement(string s, int k) {
        var arr = s.ToCharArray();
        int n = arr.Length;
    if (n == 1) return 1;
        int left = 0, right = 1;
        int max = 1;
        Dictionary<char, int> freq = new();

        char mostFreq;
        mostFreq = arr[0];
        IncreaseFreq(mostFreq);

        int replacements = 0;

        while (right < n) {
            char currentLetter = arr[right];
            IncreaseFreq(currentLetter);
            if (freq[currentLetter] > freq[mostFreq]) {
                mostFreq = currentLetter;
            }
            replacements = (right - left + 1) - freq[mostFreq];
            if (replacements > k) {
                left++;
                freq[arr[left - 1]]--;
            } else {
                max = Math.Max(max, right - left + 1);
            }

            right++;
        }
        return max;

        void IncreaseFreq(char c) {
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }
    }
}
