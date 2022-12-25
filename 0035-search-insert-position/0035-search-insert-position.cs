public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l=0;
        int r=nums.Length-1;
        int m=0;
        while(true){
            m=l+(r-l)/2;
            if(l<=r){
                if(nums[m]==target)
                    return m;
                else if(nums[m]>target)
                    r=m-1;
                else
                    l=m+1;
            }
            else{
                break;
            }
        }
        return m;
    }
}