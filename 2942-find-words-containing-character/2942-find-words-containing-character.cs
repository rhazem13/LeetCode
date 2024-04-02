public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> ans= new();
        for(int i=0;i<words.Length;i++){
            for(int j=0;j<words[i].Length;j++){
                if(words[i][j]==x){
                    ans.Add(i);
                    break;
                }
            }
        }
        return ans;
    }
}