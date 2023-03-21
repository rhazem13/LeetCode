public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        int[] ans = new int[nums.Length];
        // foreach one traverse and get the next bigger
        for(int i=0;i<nums.Length;i++){
            int idx=i+1;
            bool found=false;
            while(idx<nums.Length && !found){
                if(nums[idx]>nums[i]){
                    ans[i]=nums[idx];
                    found=true;
                }
                idx++;
            }
            idx=0;
            while(idx<i && !found){
                if(nums[idx]>nums[i]){
                    ans[i]=nums[idx];
                    found=true;
                }
                idx++;
            }
            if(!found)
                ans[i]=-1;
        }
        return ans;
    }
}