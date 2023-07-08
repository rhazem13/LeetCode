public class Solution {
    public bool RotateString(string s, string goal) {
        if(s.Length!=goal.Length)
            return false;
        // i'll iterate s until it match first char of goal
        // then i'll try to match them
        // there may be another char that match first char of goal also
        // i might even count occurences of this char
        int i1=0,i2=0,idx1=0,idx2=0;
        while(i1<s.Length){
            if(s[i1]==goal[i2]){
                idx1=i1;
                idx2=i2;
                while(s[idx1]==goal[idx2]){
                    idx1++;
                    idx2++;
                    if(idx2==goal.Length)
                        return true;
                    if(idx1==goal.Length)
                        idx1=0;
                }
            }
            i1++;
        }
        return false;
    }
}