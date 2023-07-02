public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // solve by for each letter we compare all of them yk then we return word based on counter
        int count=0;
        int i=0;
        bool diff=false;
        while(i<strs[0].Length){
            for(int j=1;j<strs.Length;j++){
                if(i>=strs[j].Length)
                    diff=true;
                else if(strs[j][i]!=strs[0][i])
                    diff=true;
            }
            if(!diff)
                count++;
            
            else
                break;
            i++;
        }
        return strs[0].Substring(0,count);
    }
}