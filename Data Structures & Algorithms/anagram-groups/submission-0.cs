public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string,List<string>>();
        int n = strs.Length;
        for(int i=0;i<n;i++){
            var sorted = SortStr(strs[i]);
            if(dict.ContainsKey(sorted)) dict[sorted].Add(strs[i]);
            else dict[sorted] = new List<string>{strs[i]};
        }
        return dict.Values.ToList();
        
    }

    private string SortStr(string t){
        var arr= t.ToCharArray();
        Array.Sort(arr);
        return String.Join("",arr);
    }
}
