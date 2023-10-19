public class Solution {
    public int[][] OnesMinusZeros(int[][] grid) {
        int m=grid.Length,n=grid[0].Length;
        int[] onesRow=new int[m];
        int[] onesCol= new int [n];
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                onesRow[i]+=grid[i][j];
                onesCol[j]+=grid[i][j];
            }
        }
        int[][] diff=new int[m][];
        for(int i=0;i<m;i++){
            diff[i]=new int[n];
            for(int j=0;j<n;j++){
                int zerosRow=m-onesRow[i];
                int zerosCol=n-onesCol[j];
                diff[i][j]=onesRow[i]+onesCol[j]-zerosRow-zerosCol;
            }
        }
        return diff;
    }
}