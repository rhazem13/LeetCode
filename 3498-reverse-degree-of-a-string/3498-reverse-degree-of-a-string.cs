public class Solution {
    public int ReverseDegree(string s) {
        int res=0;
        for(int i=0;i<s.Length;i++){
            res+= (i+1)*(26-(s[i]-'a'));
        }
        return res;
    }
}