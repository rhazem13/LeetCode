class Solution {
public:
    vector<int> findArray(vector<int>& pref) {
        vector<int> ans(pref);
        int tmp=0;
        for(int i=0;i<pref.size();i++){
            ans[i]=pref[i]^tmp;
            tmp^=ans[i];
        }
        return ans;
    }
};