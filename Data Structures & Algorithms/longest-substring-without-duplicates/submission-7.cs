public class Solution {
    public int LengthOfLongestSubstring(string s) {
    var n = s.Length;
    if(n==0 || n==1) return n;
    var arr = s.ToCharArray();
    int l = 0, r = 1;
    int max = n == 0 ? 0 : 1;
    var set = new HashSet<char>();
    set.Add(arr[l]);
    while (r < n)
    {
        set.Add(arr[r]);
        if (HasDuplicates(set, l, r))
        {
            if (arr[r] != arr[l]) set.Remove(arr[l]);
            l++;
            if (l == r) {
                r++;
            }
        }
        else
        {
            max = Math.Max(max, r - l + 1);
            r++;
        }
    }

    return max;
}
    private bool HasDuplicates(char[] arr, int l, int r) => new HashSet<char>(arr[l..(r + 1)]).Count
                                                            != r - l + 1;
    private bool HasDuplicates(HashSet<char> set, int l, int r) => set.Count < r - l + 1;
}
