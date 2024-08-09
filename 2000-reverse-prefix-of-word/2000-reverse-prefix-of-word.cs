public class Solution {
    public string ReversePrefix(string word, char ch) {
        int chIdx=-1;
        for(int i=0;i<word.Length;i++){
            if(word[i]==ch){
                chIdx=i;
                break;
            }
        }
        if(chIdx!=-1){
            StringBuilder newWord = new StringBuilder(word.Length);
            for(int i=chIdx;i>=0;i--){
                newWord.Append(word[i]);
            }
            for(int i=chIdx+1;i<word.Length;i++){
                 newWord.Append(word[i]);
            }
            return newWord.ToString();
        }
        return word;
    }
}