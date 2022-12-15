class Solution {
public:
    vector<vector<int>> generate(int numRows) {
        vector<vector<int>> ans;
        for(int i=1;i<=numRows;i++){
            vector<int> tmp(i);
                if (i == 1)
                tmp[0]=1;
            else if (i == 2) {
                tmp[0]=1;
                tmp[1]=1;
            }
            else{
                tmp[0]=1;
                tmp[i-1]=1;
                for(int idx=1;idx<tmp.size()-1;idx++){
                    tmp[idx]=ans[i-2][idx-1]+ans[i-2][idx];
                }
            }
            ans.push_back(tmp);
        }
        return ans;
    }
};