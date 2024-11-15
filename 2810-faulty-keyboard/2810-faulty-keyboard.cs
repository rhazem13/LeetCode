public class Solution {
    public string FinalString(string s) {
        List<char> ans=new();
        foreach(char c in s){
            if(c=='i'){
                ans.Reverse();
            }else{
                ans.Add(c);
            }
        }
        return new string(ans.ToArray());
    }
}