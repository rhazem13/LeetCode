public class Solution {
    public bool HasAlternatingBits(int n) {
        int bit,prevbit=3;
        bool leadingZeros=true;
        for(int i=sizeof(int)*8-1;i>=0; i--){
            bit = (n>>i)&1;
            if(bit==1)
                leadingZeros=false;
            if(!leadingZeros){
                if(prevbit==bit)
                    return false;
                prevbit=bit;
            }
        }
        return true;
    }
}