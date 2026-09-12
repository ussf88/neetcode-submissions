public class Solution {
    public bool IsAnagram(string s, string t) {
         if(s.Length != t.Length) return false;
        var tArr= t.ToCharArray();
        var sArr= s.ToCharArray();
        Array.Sort(tArr);
        Array.Sort(sArr);
        return String.Join("",tArr) == String.Join("",sArr);

    }
}
