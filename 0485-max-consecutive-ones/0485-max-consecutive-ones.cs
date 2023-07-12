public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max=-1,cur=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==0){
                if(cur>max)
                    max=cur;
                cur=0;
            }
            else{
                cur++;
            }
        }
        if(cur>max)
            max=cur;
        return max;
    }
}