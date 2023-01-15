public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int elsum=0,digitsum=0,n;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]<10){
                digitsum+=nums[i];
                elsum+=nums[i];
            }
            else{
                n=nums[i];
                while (n != 0) {
                    digitsum += n % 10;
                    n /= 10;
                }
                elsum+=nums[i];
            }
        }
        return elsum-digitsum;
    }
}