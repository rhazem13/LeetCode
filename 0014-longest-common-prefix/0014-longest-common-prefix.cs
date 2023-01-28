public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int minLength=200;
        for(int i=0;i<strs.Length;i++){
            if(strs[i].Length<minLength)
                minLength=strs[i].Length;
        }
        int builderIndex=0,ans=0;
        while(builderIndex<minLength){
            bool isPre=true;
            char c=strs[0][builderIndex];
            for(int i=1;i<strs.Length;i++){
                if(strs[i][builderIndex]!=c)
                    isPre=false;
            }
            if(isPre)
                ans++;
            else{
                break;
            }
            builderIndex++;
        }
        return strs[0].Substring(0,ans);
    }
}