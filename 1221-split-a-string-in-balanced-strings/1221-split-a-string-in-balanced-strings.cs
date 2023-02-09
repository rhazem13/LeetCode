public class Solution {
    public int BalancedStringSplit(string s) {
        int rCount=0,lCount=0,ans=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='R')
                rCount++;
            if(s[i]=='L')
                lCount++;
            if(rCount==lCount){
                rCount=0;
                lCount=0;
                ans++;
            }
        }
        return ans;
    }
}