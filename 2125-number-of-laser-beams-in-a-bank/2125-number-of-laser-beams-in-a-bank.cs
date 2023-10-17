public class Solution {
    public int NumberOfBeams(string[] bank) {
        // make arr of count foreach row
        int[] countarr=new int[bank.Length];
        for(int i=0;i<bank.Length;i++){
            countarr[i]=0;
            foreach(var c in bank[i])
                if(c=='1')
                    countarr[i]++;
        }
        int idx=0,prev=0,result=0,tmp;
        while(idx<countarr.Length){
            if(countarr[idx]>0){
                result+=prev*countarr[idx];
                prev=countarr[idx];
            }
            idx++;
        }
        return result;
    }
}