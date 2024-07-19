public class Solution {
    public IList<string> ValidStrings(int n) {
        // backtracking
        StringBuilder sb = new StringBuilder(new string(' ',n));
        IList<string> ans= new List<string>();
        BackTracker(ans,sb,0,n);
        return ans;
    }

    public void BackTracker(IList<string> ans, StringBuilder sb, int i, int n){
        if(i==n){
            if(ValidBinaryString(sb)){
                ans.Add(sb.ToString());
            }
            return;
        }
        sb[i]='0';
        BackTracker(ans,sb,i+1,n);
        sb[i]='1';
        BackTracker(ans,sb,i+1,n);
    }

    public bool ValidBinaryString(StringBuilder sb){
        for(int i=0;i<sb.Length-1;i++){
            if(sb[i]=='0' && sb[i+1]=='0')
                return false;
        }
        return true;
    }
}