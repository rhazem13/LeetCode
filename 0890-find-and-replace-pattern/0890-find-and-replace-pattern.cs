public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        List<string> res =new();
        bool match;
        for(int i=0;i<words.Length;i++){
            match=true;
            Dictionary<char,char> d1=new();
            Dictionary<char,char> d2=new();
            int j=0;
            while(j<words[i].Length&&match){
                if(d1.ContainsKey(pattern[j])){
                    if(d2.ContainsKey(words[i][j])){
                        if(d1[pattern[j]]!=words[i][j] || d2[words[i][j]]!=pattern[j])match=false;
                    } else {
                        match=false;
                    }
                } else {
                    if(d2.ContainsKey(words[i][j])){
                        match=false;
                    } else {
                        d1.Add(pattern[j],words[i][j]);
                        d2.Add(words[i][j],pattern[j]);
                    }
                }
                j++;
            }
            if(match)res.Add(words[i]);
        }
        return res;
    }
}