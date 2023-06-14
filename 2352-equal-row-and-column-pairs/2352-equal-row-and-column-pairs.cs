public class Solution {
    public int EqualPairs(int[][] grid) {
        int ans=0;
        // iterate rows
        for(int row=0; row<grid.Length; row++){
            // for each row iterate columns to find matches
            // this for loop iterate columns
            for(int col=0;col<grid.Length;col++){
                ans++;
                // now compare each col to the current row
                for(int i=0;i<grid.Length;i++){
                    if(grid[row][i]!=grid[i][col]){
                        ans--;
                        break;
                    }
                }
            }
        }
        return ans;
    }
}