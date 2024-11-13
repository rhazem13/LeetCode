public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        // i think making a hashset for each character and checking against it by iterating
        // the character of each string in words would be efficient
        HashSet<char> hashSet = new HashSet<char>();
        foreach(char c in allowed){
            hashSet.Add(c);
        }
        int ans=0;
        bool valid;
        foreach(string word in words){
            valid=true;
            for(int i=0;i<word.Length;i++){
                if(!hashSet.Contains(word[i])){
                    valid=false;
                    break;
                }
            }
            if(valid)ans++;
        }
        return ans;
    }
}