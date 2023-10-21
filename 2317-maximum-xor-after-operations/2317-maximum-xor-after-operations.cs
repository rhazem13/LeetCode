public class Solution {
    public int MaximumXOR(int[] nums) {
        int res=nums[0];
        for(int i=0;i<nums.Length;i++){
            res = res | nums[i];
        }
        return res;
    }
}