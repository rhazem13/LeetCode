public class Solution {
    public int TitleToNumber(string columnTitle) {
        int ans=0;
        int doubler=0;
        for(int i=columnTitle.Length-1;i>-1;i--){
            ans+=(columnTitle[i]-'A' + 1)*(int)Math.Pow(26,doubler);
            doubler+=1;
        }
        return ans;
    }
}