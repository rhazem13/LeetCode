public class Solution {
    public int LengthOfLastWord(string s) {
        int ans=0;
        for(int i=s.Length-1;i>=0;i--){
            while(s[i]==' ' && ans==0){
                i--;
            }
            if(s[i]==' ')
                break;
            ans++;
        }
        return ans;
    }
}