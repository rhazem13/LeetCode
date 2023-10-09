public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] result = new int[n][];
        for(int i=0;i<n;i++){
            result[i]=new int[n];
        }
        int num=1;
        for(int i=0,j=n-1;i<=j;i++,j--){
            // right
            for(int x=i;x<=j;x++)
                result[i][x]=num++;
            // down
            for(int x=i+1;x<=j;x++)
                result[x][j]=num++;
            // left
            for(int x=j-1;x>=i;x--)
                result[j][x]=num++;
            // up
            for(int x=j-1;x>i;x--)
                result[x][i]=num++;
        }
        return result;
    }
}