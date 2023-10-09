public class Solution {
    public string CountAndSay(int n) {
        if(n==1) return "1";
        string s = CountAndSay(n-1);
        // now we say tmp and return it
        int t = s.Length;
        StringBuilder res = new();
        int currentCount = 0;
        for(int i=0;i<t-1;i++){
            currentCount++;
            if(s[i]!=s[i+1]){
                res.Append(currentCount.ToString());
                res.Append(s[i].ToString());
                currentCount=0;
            }
        }
        currentCount++;
        res.Append(currentCount.ToString());
        res.Append(s[t-1].ToString());
        return res.ToString();
    }
}