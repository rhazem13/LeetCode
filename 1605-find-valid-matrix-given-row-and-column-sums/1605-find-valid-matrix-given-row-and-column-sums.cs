public class Solution {
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum) {
        int[][] matrix= new int[rowSum.Length][];
        int matrixX=0;
        int matrixY =0;
        for (int i = 0; i < rowSum.Length; i++){
            matrix[i] = new int[colSum.Length];
        }
        // Find the smallest rowSum or colSum, and let it be x. 
        // Place that number in the grid, and subtract x from rowSum and colSum. 
        // Continue until all the sums are satisfied.
        int countZeros;
        while(true){
            int x = int.MaxValue;
            int y = int.MaxValue;
            countZeros=0;
            for(int i=0;i<rowSum.Length;i++){
                if(rowSum[i]!=0 && rowSum[i]<x){
                    x = rowSum[i];
                    matrixX = i;
                } else countZeros++;
            }
            if(countZeros==rowSum.Length) break;
            for(int i=0;i<colSum.Length;i++){
                if(colSum[i]!=0 && colSum[i]<y){
                    y = colSum[i];
                    matrixY = i;
                }
            }
            if(x<y){
                matrix[matrixX][matrixY] = x;
                rowSum[matrixX] -= x;
                colSum[matrixY] -= x;
            } else {
                matrix[matrixX][matrixY] = y;
                rowSum[matrixX] -= y;
                colSum[matrixY] -= y;
            }
        }
        return matrix;
    }
}