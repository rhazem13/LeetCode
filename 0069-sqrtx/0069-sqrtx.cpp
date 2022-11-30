class Solution {
public:
    int mySqrt(int x) {
        for(long i=0;i<x;i++){
            long l=i*i;
            long r=(i+1)*(i+1);
            if(l<=x && x<=r){
                if(x==r)
                    return i+1;
                return i;
            }
        }
        if(x==0)
            return 0;
        return -1;
    }
};