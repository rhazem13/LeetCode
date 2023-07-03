public class Solution {
    public bool BuddyStrings(string s, string goal) {
        if(s.Length!=goal.Length)
            return false;
        // iterate over s
        // if diff put in dict
        // if dict is empty by the end check if there is repeated letters using hashset
        Dictionary<char,char> dict=new();
        HashSet<char> set=new();
        bool duplicates=false;
        for(int i=0;i<s.Length;i++){
            if(s[i]!=goal[i]){
                if(dict.Count>1)
                    return false;
                else if (dict.Count==1){
                    if(!dict.ContainsKey(s[i]))
                        return false;
                    if(dict[s[i]]!=goal[i])
                        return false;
                    dict[goal[i]]=s[i];
                }
                else{
                    dict[goal[i]]=s[i];
                }
            }
            if(set.Contains(s[i])){
                duplicates=true;
            }
            set.Add(s[i]);
        }
        return (dict.Count!=1) && (dict.Count>0 || duplicates) ? true:false;
    }
}