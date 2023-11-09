public class Solution{
    
    public int CountHomogenous(string s)
{   
    int streak=1;
    int res=1;
    int mod = 1000000007;
        for(int i=0; i<s.Length-1;i++)
        {
            if(s[i]==s[i+1])
            {
                streak++;                
            }
            else
            {
                streak=1;
            }
            res+=streak;
            res%=mod;            
        }
        return res;
    }
}