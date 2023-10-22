public class Solution {
    public int TriangularSum(int[] nums, int length){
        if(length==1)
            return nums[0];
        // int[] newarr= new int[nums.Length-1];
        int i=0;
        while(i<length-1){
            nums[i]=(nums[i]+nums[i+1])%10;
            i++;
        }
        return TriangularSum(nums,length-1);
    }
    public int TriangularSum(int[] nums) {
        return TriangularSum(nums,nums.Length);
    }
}