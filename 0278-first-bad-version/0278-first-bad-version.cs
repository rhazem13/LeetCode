/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        bool foundbad=false;
        while(true){
            if(IsBadVersion(n)){
                foundbad=true;
                n/=2;
            }
            else if(!IsBadVersion(n)){
                if(foundbad){
                    while(!IsBadVersion(n)){
                        n++;
                    }
                    return n;
                }
            }
        }
    }
}