public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> d=new();
        foreach(var c in s){
            d[c]=0;
        }
        foreach(var c in t){
            d[c]=0;
        }
        foreach(var c in s){
            d[c]++;
        }
        foreach(var c in t){
            d[c]--;
        }
        foreach(var item in d){
            if(item.Value!=0)
                return false;
        }
        return true;
    }
}