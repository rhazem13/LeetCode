public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        StringBuilder str=new();
        for(int i=0;i<word1.Length;i++){
            for(int j=0;j<word1[i].Length;j++){
                str.Append(word1[i][j]);
            }
        }
        int idx=0;
        for(int i=0;i<word2.Length;i++){
            for(int j=0;j<word2[i].Length;j++){
                if(idx>=str.Length) return false;
                if(str[idx]!=word2[i][j]) return false;
                idx++;
            }
        }
        return idx==str.Length;
    }
}