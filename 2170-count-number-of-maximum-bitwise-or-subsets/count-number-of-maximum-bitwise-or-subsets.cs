public class Solution {
    public int CountMaxOrSubsets(int[] nums) {
        // maxbitwise = bitwise of whole array
        int maxbitwise=0;
        foreach(var n in nums){
            maxbitwise |=n;
        }
        // backtracking 
        return backtrack(nums, 0, 0, maxbitwise);
    }
    public int backtrack(int[] nums, int index, int currentBitWise, int maxbitwise){
        if(index==nums.Count()){
            if(currentBitWise==maxbitwise){
                return 1;
            } else {
                return 0;
            }
        }
        if(currentBitWise==maxbitwise){
                return  backtrack(nums,index+1,currentBitWise|nums[index],maxbitwise)+ backtrack(nums,index+1,currentBitWise,maxbitwise);
            } else {
                return  backtrack(nums,index+1,currentBitWise|nums[index],maxbitwise)+ backtrack(nums,index+1,currentBitWise,maxbitwise);
            }
        
    }
}