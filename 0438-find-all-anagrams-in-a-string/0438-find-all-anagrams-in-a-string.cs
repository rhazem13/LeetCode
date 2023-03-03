public class Solution {
    public Dictionary<char,int> d;
    public bool isValid(){
        foreach(var kvp in d){
            if(kvp.Value!=0)
                return false;
        }
        return true;
    }
    public IList<int> FindAnagrams(string s, string p) {
        List<int> ans=new();
        if(p.Length>s.Length)
            return ans.ToArray();
        // make dict with each char and its count
        d=new();
        foreach(var n in p){
            if(d.ContainsKey(n))
                d[n]++;
            else
                d.Add(n,1);
        }
        // solve it in o(n) by sliding window
        int l=0,r=0;
        while(r<p.Length){
            if(d.ContainsKey(s[r]))
                d[s[r]]--;
            r++;
        }
        r--;
        // traversing S and each step we check if it satisfy the condition
        while(r<s.Length-1){
            if(isValid())
                ans.Add(l);
            if(d.ContainsKey(s[l]))
                d[s[l]]++;
            l++;
            r++;
            if(d.ContainsKey(s[r]))
                d[s[r]]--;
        }
        if(isValid())
                ans.Add(l);
        // i mean cheack if dict values equal the way it should be (sliding window)
        // if it is we add the index to ans list
        // each step we remove the leftmost letter and add the rightmost one
        return ans.ToArray();
    }
}