public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if (strs == null || strs.Length == 0)
            return new List<IList<string>>();
        
        List<IList<string>> res = new List<IList<string>>();
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        
        foreach (var str in strs)
        {
            string cur = new string(str.OrderBy(x => x).ToArray());
            
            if (!dict.ContainsKey(cur))
                dict.Add(cur, new List<string>());
            
            dict[cur].Add(str);
        }
        
        foreach (var item in dict.Values)
            res.Add(item);
        
        return res;
    }
}