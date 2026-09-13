public class Solution {

    public string Encode(IList<string> strs) {
        int n= strs.Count;
        var sb = new StringBuilder();
        sb.Append(n);
        sb.Append("%");
        for(int i=0;i<n;i++){
            var str = strs[i];
            var k = str.Length;
            sb.Append(k);
            sb.Append("%");
            sb.Append(str);
            
        }
       return sb.ToString();   
    }

    public List<string> Decode(string s) {
 
        var arr = s.ToCharArray();
        var(l,i)=GetLength(arr);
        var rez = new List<string>(l);
        int l1=0,i1=i;  
        while(rez.Count<=l){
            if(i1>=s.Length)break;

            (l1,i1)=GetLength(arr,i1);
            rez.Add(s.Substring(i1,l1));
            i1+=l1;
        
        }
  
        return  rez;
   }
   private (int l,int i) GetLength(char[] chars, int start = 0){
    int n=chars.Length;
     if(start>=n) return (0,n);
     StringBuilder sb = new();
     int i=start;
     while(i<n && chars[i]!='%') {
        sb.Append(chars[i]);
        i++;
     }
         return (int.Parse(sb.ToString()),i+1);
   }
 
}
