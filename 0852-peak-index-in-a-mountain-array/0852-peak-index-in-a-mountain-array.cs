public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int l=1,r=arr.Length-2,m=0;
        while(l<=r){
            m=l+(r-l)/2;
            if(arr[m]>=arr[m-1]&&arr[m]>=arr[m+1]){
                return m;
            }
            else if(arr[m]<arr[m-1]){
                r=m-1;
            }
            else{
                l=m+1;
            }
        }
        return -1;
    }
}