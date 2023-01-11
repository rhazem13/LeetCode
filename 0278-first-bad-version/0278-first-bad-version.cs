/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int l=0;
        int r=n;
        int ans=-1;
        while(true){
            int m=l+(r-l)/2;
            if(!IsBadVersion(m)){
                l=m+1;
            }
            else if(IsBadVersion(m-1)){
                r=m-1;
                ans=m-1;
            }
            else{
                return m;
            }
        }
        return ans;
    }
}