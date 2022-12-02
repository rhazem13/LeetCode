// The API isBadVersion is defined for you.
// bool isBadVersion(int version);

class Solution {
public:
    int firstBadVersion(int n) {
        int l=1;
        int r=n;
        int ans=-1;
        while(true){
            int m=l+(r-l)/2;
            if(!isBadVersion(m)){
                l=m+1;
            }
            else {
                if(isBadVersion(m-1)){
                    r=m-1;
                    ans=m-1;
                }
                else{
                    return m;
                }
            }
        }
        return ans;

    }
};