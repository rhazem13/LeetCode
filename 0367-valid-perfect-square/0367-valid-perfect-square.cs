public class Solution {
    public bool IsPerfectSquare(int num) {
        Int64  l=0;
        Int64  r=num,m,tmp;
        while(l<=r){
            m=(l+r)/2;
            tmp=m*m;
            if(tmp==num)
                return true;
            else if(tmp<num){
                l=m+1;
            }
            else{
                r=m-1;
            }
        }
        return false;
    }
}