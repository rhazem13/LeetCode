public class Solution {
    public int[] ExecuteInstructions(int n, int[] startPos, string s) {
        int[] result = new int[s.Length];
        int x,y,curindex;
        bool blocked=false,outbounds=false;
        // for each char of ith instruction we count how many instructions can happen
        for(int i=0;i<s.Length;i++){
            result[i]=0;
            x=startPos[0];
            y=startPos[1];
            curindex=i;
            blocked=false;
            outbounds=false;
            while(!blocked && !outbounds){
                if(s[curindex]=='L'){
                    if(y-1>=0){
                        y--;
                        result[i]++;
                    }
                    else{
                        blocked=true;
                    }
                }
                else if(s[curindex]=='R'){
                    if(y+1<n){
                        y++;
                        result[i]++;
                    }
                    else{
                        blocked=true;
                    }
                }
                else if(s[curindex]=='U'){
                    if(x-1>=0){
                        x--;
                        result[i]++;
                    }
                    else{
                        blocked=true;
                    }
                }
                else if(s[curindex]=='D'){
                    if(x+1<n){
                        x++;
                        result[i]++;
                    }
                    else{
                        blocked=true;
                    }
                }
                curindex++;
                if(curindex>=s.Length)
                    outbounds=true;
                else
                    outbounds=false;
            }

        }
        return result;
    }
}