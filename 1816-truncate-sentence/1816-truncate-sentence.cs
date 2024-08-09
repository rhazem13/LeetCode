public class Solution {
    public string TruncateSentence(string s, int k) {
        StringBuilder res = new();
        for(int i=0;i<s.Length;i++){
            if(s[i]==' ') k--;
            if(k==0) break;
            res.Append(s[i]);
        }
        return res.ToString();
    }
}