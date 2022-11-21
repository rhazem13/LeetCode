class Solution {
public:
    vector<vector<int>> groupThePeople(vector<int>& groupSizes) {
        int n=groupSizes.size();
        if(n==1){
            vector<vector<int>> ans(1,vector<int>(1));
            return ans;
        }
        if(n==groupSizes[0]){
            vector<vector<int>> ans(1,vector<int>());
            for(int i=0;i<n;i++){
                ans[0].push_back(i);
            }
            return ans;
        }
        int e;
        vector<vector<int>> ans(n,vector<int>());
        for(int i=0;i<n;i++){
            ans[groupSizes[i]].push_back(i);
        }
        vector<vector<int>> finalAns;
        for(int i=0;i<n;i++){
            if(ans[i].size()!=0){
                finalAns.push_back(ans[i]);
            }
        }
        for(int i=0;i<finalAns.size();i++){
            if(finalAns[i].size()!=groupSizes[finalAns[i][0]]){
                int diff=finalAns[i].size()-groupSizes[finalAns[i][0]];
                vector<int> newGroup1,newGroup2;
                for(int j=0;j<finalAns[i].size();j++){
                    if(j<diff){
                        newGroup1.push_back(finalAns[i][j]);
                    }
                    else{
                        newGroup2.push_back(finalAns[i][j]);
                    }
                }
                finalAns[i]=newGroup2;
                finalAns.push_back(newGroup1);

            }
        }
        return finalAns;
    }
};