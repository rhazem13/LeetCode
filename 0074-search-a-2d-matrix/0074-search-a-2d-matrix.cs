public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m=matrix.Length,n=matrix[0].Length;
        int left=0,right=m-1,mid;
        while(left<=right){
            mid=left+(right-left)/2;
            if(target>= matrix[mid][0] && target <= matrix[mid][n-1]){
                int res = Array.BinarySearch(matrix[mid],target);
                if(res<0)
                    return false;
                else
                    return true;
            }
            else if(target<=matrix[mid][0]){
                right=mid-1;
            }
            else
                left=mid+1;
        }
        return false;
    }
}