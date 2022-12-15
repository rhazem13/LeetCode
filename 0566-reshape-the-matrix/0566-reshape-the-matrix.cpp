class Solution {
public:
    vector<vector<int>> matrixReshape(vector<vector<int>>& mat, int r, int c) {
        if(mat.size()*mat[0].size()!=r*c)
            return mat;
        vector<vector<int>> ans(r,vector<int>(c));
        int ridx=0,cidx=0;
        for(int i=0;i<mat.size();i++){
            for(int j=0;j<mat[i].size();j++){
                ans[ridx][cidx]=mat[i][j];
                if(cidx==c-1){
                    cidx=0;
                    ridx++;
                }
                else
                    cidx++;
            }
        }
        return ans;
    }
};