public class Solution {
    public int HammingWeight(uint n) {
        int ans=0;
        string s=Convert.ToString(n,2);
        for(int i=0;i<s.Length;i++){
            ans+=s[i]=='1'?1:0;
        }
        return ans;
    }
}