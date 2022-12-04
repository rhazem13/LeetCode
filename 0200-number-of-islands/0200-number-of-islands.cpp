class Solution {
public:
    int result=0;
    void island(vector<vector<char>>& grid,int i,int j,int n,int m){
        if(i<0 ||i==n||j<0||j==m) //boundry conditions
        return;
        if(grid[i][j]=='0' || grid[i][j]=='2') //either not to be traversed or it is already traversed
        return;
        grid[i][j]='2'; //it means the index has been traversed
        island(grid,i,j-1,n,m);  //left
        island(grid,i,j+1,n,m);  //right
        island(grid,i-1,j,n,m);  //top
        island(grid,i+1,j,n,m);  //down
    }
    int numIslands(vector<vector<char>>& grid) {
        int n=grid.size();
        int m=grid[0].size();
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(grid[i][j]=='1'){ //this will give the number of new components
                result++;
                island(grid,i,j,n,m);
                }
            }
        }
        return result;
    }
};