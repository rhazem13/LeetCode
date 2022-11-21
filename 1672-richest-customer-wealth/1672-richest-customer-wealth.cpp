class Solution {
public:
    int maximumWealth(vector<vector<int>>& accounts) {
        int maximumWealth=0;
        int tempWealth=0;
        for(int i=0;i<accounts.size();i++){
            tempWealth=0;
            for(int j=0;j<accounts[i].size();j++){
                tempWealth+=accounts[i][j];
            }
            if(tempWealth>maximumWealth){
                maximumWealth=tempWealth;
            }
        }
        return maximumWealth;
    }
};