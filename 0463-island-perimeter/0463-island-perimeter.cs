public class Solution {
    public int IslandPerimeter(int[][] grid) {
        // iterate it if the boundary is so big or water count it ^^
        int count=0;
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[i].Length;j++){
                if(grid[i][j]==1){
                    //here we check 4 directions
                    // up
                    if(i-1<0)
                        count++;
                    else
                        if(grid[i-1][j]==0)
                            count++;
                    // down
                    if(i+1>=grid.Length)
                        count++;
                    else
                        if(grid[i+1][j]==0)
                            count++;
                    // left
                    if(j-1<0)
                        count++;
                    else
                        if(grid[i][j-1]==0)
                            count++;
                    // right
                    if(j+1>=grid[i].Length)
                        count++;
                    else
                        if(grid[i][j+1]==0)
                            count++;
                }
            }
        }
        return count;
    }
}