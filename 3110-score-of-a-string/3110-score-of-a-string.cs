public class Solution {
    public int ScoreOfString(string s) {
        int sum = 0;
        int abs=0;
        for(int i=0;i<s.Length-1;i++){
            abs = Math.Abs(s[i]-s[i+1]);
            sum+=abs;
        }
        return sum;
    }
}