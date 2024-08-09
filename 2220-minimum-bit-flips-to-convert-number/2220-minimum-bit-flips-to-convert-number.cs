public class Solution {
    public int MinBitFlips(int start, int goal) {
        int xor= start^goal;
        int res=0;
        while(xor > 0){
            res+= xor&1;
            xor>>=1;
        }
        return res;
    }
}