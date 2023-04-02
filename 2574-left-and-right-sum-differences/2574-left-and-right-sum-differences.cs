public class Solution {
    public int[] LeftRigthDifference(int[] nums) {
        int leftSum = 0, rightSum=nums.Sum();
        for(int i=0;i<nums.Length;i++){
            int tmp = nums[i];
            rightSum-=tmp;
            nums[i]=Math.Abs(rightSum-leftSum);
            leftSum+=tmp;
        }
        return nums;
    }
}