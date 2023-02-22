public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        if (s == null || s == string.Empty)
            return false;
        
        for (int i = 0; i < s.Length / 2; i++)
            if (Helper(s, s.Substring(0, i + 1), 0))
                return true;
        
        return false;
    }
    
    private bool Helper(string s, string sub, int i)
    {
        if (i == s.Length)
            return true;
        else if (s.Length - i >= sub.Length && s.Substring(i, sub.Length) == sub)
            return Helper(s, sub, i + sub.Length);
        
        return false;
    }
}