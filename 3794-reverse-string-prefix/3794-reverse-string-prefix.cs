using System.Text;

public class Solution {
    public string ReversePrefix(string s, int k) {
        // 1. StringBuilder must be capitalized
        StringBuilder res = new();
        
        // 2. Loop should go from k down to 0 to include the first char
        int i = k-1;
        while(i >= 0){
            res.Append(s[i]);
            i--;
        }
        
        // 3. Substring takes (startIndex, length)
        // Since we took up to index k, we start at k + 1
        if (k < s.Length) {
            res.Append(s.Substring(k));
        }
        
        // 4. Must call .ToString()
        return res.ToString();
    }
}