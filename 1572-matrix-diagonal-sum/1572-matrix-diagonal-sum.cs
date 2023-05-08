public class Solution {
    public int DiagonalSum(int[][] mat) {
        int sum=0,l=0,r=mat.Length-1;
        for(int i=0;i<mat.Length;i++){
            sum+=mat[i][l];
            sum+=mat[i][r];
            if(l==r){
                sum-=mat[i][r];
            }
            l++;
            r--;
        }
        
          return sum;
        
    }
}