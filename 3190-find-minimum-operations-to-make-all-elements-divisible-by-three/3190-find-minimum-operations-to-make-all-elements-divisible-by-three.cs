public class Solution {
    public int MinimumOperations(int[] nums) {
        int operations =0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==1 || nums[i]%3!=0 ){
                operations++;
            } 
        }
        return operations;
    }
}