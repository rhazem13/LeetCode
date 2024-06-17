public class Solution {
    public int FindPermutationDifference(string s, string t) {
        int sum=0;
        for(int i=0;i<s.Length;i++){
            int idxt=0;
            while(t[idxt]!=s[i])
                    idxt++;
            sum+= Math.Abs(i-idxt);
        }
        return sum;
    }
}