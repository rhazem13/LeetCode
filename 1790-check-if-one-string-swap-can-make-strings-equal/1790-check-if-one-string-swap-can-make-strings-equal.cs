public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        int counter=0;
        char? c=null,cc=null;
        for(int i=0;i<s1.Length;i++){
            if(s1[i]!=s2[i]){
                counter++;
                if(c==null){
                    c=s1[i];
                    cc=s2[i];
                }
                else if(c!=null){
                    if(s2[i]!=c||s1[i]!=cc)
                    return false;
                }
            }
        }
        return counter==2||counter==0;
    }
}