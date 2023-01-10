public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int l=0,r=letters.Length-1,m;
        while(l<=r){
            m=l+(r-l)/2;
            if(letters[m]-'0'>target-'0')
                r=m-1;
            else{
                l=m+1;
            }
        }
        if(l>=letters.Length) l = 0;
        return letters[l];
    }
}