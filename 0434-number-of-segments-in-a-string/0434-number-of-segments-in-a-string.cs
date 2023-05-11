public class Solution {
    public int CountSegments(string s) {
        int count = 0, i=0;

        while(i<s.Length && s[i] == ' '){
            i++;
        }

        while(i<s.Length){
            count++;

            while(i<s.Length && s[i] != ' '){
                i++;
            }

            while(i<s.Length && s[i] == ' '){
                i++;
            }
        }

        return count;
    }
}