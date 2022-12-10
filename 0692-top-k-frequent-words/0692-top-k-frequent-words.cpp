class Solution {
public:
    vector<string> topKFrequent(vector<string>& words, int k) {
        vector<string> ans(k);
        map<string,int> mymap;
        for(int i=0;i<words.size();i++){
            mymap[words[i]]++;
        }
        int maxFreq=-1;
        string maxStr;
       
        for(int m=0;m<k;m++){
            for(auto i : mymap) {
            if(i.second>maxFreq){
                maxFreq=i.second;
                maxStr=i.first;
            }
          }
            ans[m]=(maxStr);
            mymap[maxStr]=0;
            maxFreq=-1;
        }
        return ans;
    }
};