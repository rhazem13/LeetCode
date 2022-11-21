class Solution {
public:
    int maxIncreaseKeepingSkyline(vector<vector<int>>& grid) {
        int n=grid.size();
        vector<int> west(n,0);
        vector<int> south(n,0);
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j]>west[i]){
                    west[i]=grid[i][j];
                }
                if(grid[i][j]>south[j]){
                    south[j]=grid[i][j];
                }
            }
        }
        int newVal;
        int ans=0;
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                newVal=min(west[i],south[j]);
                ans+=newVal-grid[i][j];
            }
        }

        return ans;
    }
};