public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char> rset;
        HashSet<char>[] csets = new HashSet<char>[9];
        HashSet<char>[] ssets = new HashSet<char>[9];
        for(int i=0;i<9;i++){
            rset = new HashSet<char>(9);
            for(int j=0;j<9;j++){
                if (ExistsAndAdd(rset,board[i][j])) return false;
                if(csets[j] is null) csets[j] = new HashSet<char>(9);
                if (ExistsAndAdd( csets[j],board[i][j])) return false;
                int index = (i / 3) * 3 + (j / 3);
                if(ssets[index] is null) ssets[index] = new HashSet<char>(9);
                if (ExistsAndAdd( ssets[index],board[i][j])) return false; 
            }
        }
      
        return true;
    }
    private bool ExistsAndAdd(HashSet<char> set, char c){
        if(c=='.') return false;
        int n=set.Count;
        set.Add(c);
        return n==set.Count;
    }
}
