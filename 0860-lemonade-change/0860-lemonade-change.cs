public class Solution {
    public bool LemonadeChange(int[] bills) {
        int fivz=0,tenz=0,twentz=0;
        foreach(var n in bills){
            if(n==5)
                fivz++;
            else if(n==10){
                if(fivz<1)
                    return false;
                tenz++;
                fivz--;
            }
            else if(n==20){
                if(tenz>0){
                    tenz--;
                    if(fivz<1)
                        return false;
                    fivz--;
                }
                else{
                    if(fivz<3)
                        return false;
                    fivz-=3;
                }
            }
        }
        return true;
    }
}