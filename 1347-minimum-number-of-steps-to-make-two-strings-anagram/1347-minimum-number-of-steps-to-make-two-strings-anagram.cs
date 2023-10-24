public class Solution {
    public int MinSteps(string s, string t) {
        Dictionary<char,int> dict = new();
        foreach(var c in s){
            if(dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c]=1;
        }
        foreach(var c in t){
            if(dict.ContainsKey(c))
                dict[c]--;
        }
        int res=0;
        foreach(var kvp in dict){
            if(kvp.Value>0)
                res+=kvp.Value;
        }
        return res;
    }
}