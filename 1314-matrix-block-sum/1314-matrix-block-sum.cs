public class Solution {
    public int[][] MatrixBlockSum(int[][] mat, int k) {
        int[][] answer = new int[mat.Length][];
        for(int i=0;i<mat.Length;i++) answer[i]=new int[mat[0].Length];

        for(int i=0;i<mat.Length;i++){
            for(int j=0;j<mat[0].Length;j++){
                int sum=0;
                for(int r=i-k;r<=i+k;r++){
                    if(r<0||r>=mat.Length) continue;
                    for(int c=j-k;c<=j+k;c++){
                        if(c<0||c>=mat[0].Length)continue;
                        sum+=mat[r][c];
                    }
                }
                answer[i][j]=sum;
            }
        }
        return answer;
    }
}