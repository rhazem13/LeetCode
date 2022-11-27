class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        string s=strs[0];
        bool isPrefix=false;
         bool isLocalPrefix=false;
        while(!isPrefix){
            for(int i=0;i<strs.size();i++){
                if(i==strs.size()-1 && isLocalPrefix && string(strs[i]).find(s)==0 ){
                    return s;
                }
                if(string(strs[i]).find(s)==0){
                    isLocalPrefix=true;
                }
                else{
                    isLocalPrefix=false;
                    break;
                }
            }
            if(!isLocalPrefix){
                s.pop_back();
            }
        }
        return "";
    }
};