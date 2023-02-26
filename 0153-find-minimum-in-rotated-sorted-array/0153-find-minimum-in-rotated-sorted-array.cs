public class Solution {
    public int FindMin(int[] nums) {
        int l=0,m,r=nums.Length-1;
        while(l<r){
            m=l+(r-l)/2;
            if(nums[m]>nums[r])
                l=m+1;
            else
                r=m;
        }
        return Math.Min(nums[0],nums[l]);
    }
}