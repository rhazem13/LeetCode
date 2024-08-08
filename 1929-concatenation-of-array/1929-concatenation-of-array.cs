public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] res=new int[nums.Length*2];
        for(int i=0;i<nums.Length;i++){
            res[i+nums.Length]=nums[i];
            res[i]=nums[i];
        }
        return res;
    }
}