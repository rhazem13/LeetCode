public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int idxpos=0,idxneg=1;
        int[] result=new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            if(nums[i]>0){
                result[idxpos]=nums[i];
                idxpos+=2;
            }
            else{
                result[idxneg]=nums[i];
                idxneg+=2;
            }
        }
        return result;
    }
}