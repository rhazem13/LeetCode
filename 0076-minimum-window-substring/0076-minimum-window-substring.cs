public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length)
        return "";
        if(s.Length==1){
            if(s[0]==t[0])
                return Char.ToString(s[0]);
            return "";
        }
        Dictionary<char, int> d = new();
        foreach (var c in t)
        {
            if(!d.ContainsKey(c))
                d.Add(c, 0);
        }
        foreach (var c in t)
        {
            d[c]++;
        }
        //if lengths are equal
        if(t.Length==s.Length){
            foreach(var c in s){
                decrement(d,c);
            }
            if(!covered(d))
                return "";
            return s;
        }
        // Use two pointers to create a window of letters in s, which would have all the characters from t.
        int lp = 0, rp = 0, anslp = 0, ansrp = 0, minWin = Int32.MaxValue;
        decrement(d, s[lp]);
        List<char> list = new();
        while (rp < s.Length-1)
        {
            // Expand the right pointer until all the characters of t are covered.
            while (!covered(d) && rp < s.Length-1)
            {
                rp++;
                decrement(d, s[rp]);
            }
            // Once all the characters are covered, move the left pointer and ensure that all the characters
            // are still covered to minimize the subarray size.
            while (covered(d) && lp <= rp)
            {
                increment(d, s[lp]);
                lp++;
            }
            if (lp > 0) { 
                lp--;
                decrement(d, s[lp]);
            }
            // Continue expanding the right and left pointers until you reach the end of s.
            if ((rp - lp) < minWin)
            {
                minWin = rp - lp;
                anslp = lp;
                ansrp = rp;
            }
            increment(d, s[lp]);
            lp++;
        }
        lp--;
        decrement(d,s[lp]);
        if(!covered(d))
            return "";
        return s.Substring(anslp, ansrp - anslp + 1);
    }
    public bool covered(Dictionary<char,int> d){
        foreach(var kvp in d){
            if(kvp.Value>0)
                return false;
        }
        return true;
    }
    public void increment(Dictionary<char,int> d, char c){
        if(d.ContainsKey(c)){
            d[c]++;
        }
    }
    public void decrement(Dictionary<char,int> d,char c){
        if(d.ContainsKey(c)){
            d[c]--;
        }
    }
}