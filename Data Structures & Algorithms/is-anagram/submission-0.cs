public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var dict = new Dictionary<char,int>();
        for(int i =0;i<s.Length;i++){
            if(dict.ContainsKey(s[i])) dict[s[i]]++;
            else dict[s[i]] = 1;
            if(dict.ContainsKey(t[i])) dict[t[i]] --;
            else dict[t[i]] = - 1;
        }
        var anagram = false;
        foreach(var (_,v) in dict){
            if(v!=0) return false;
        }
        return true;
    }
}
