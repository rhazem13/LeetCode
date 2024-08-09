public class Solution {
    public int XorOperation(int n, int start) {
        int[] nums = new int[n];
        for(int i=0;i<nums.Length;i++){
            nums[i] = start + 2 * i;
        }
        int res=nums[0];
        for(int i=1;i<nums.Length;i++){
            res ^= nums[i];
        }
        return res;
    }
}