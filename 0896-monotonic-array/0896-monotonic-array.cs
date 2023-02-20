public class Solution {
    public bool IsMonotonic(int[] nums) {
        if(nums.Length==1)
            return true;
        //state 0 is begining
        // 1  increasing
        // 2  decreasing
        int state=0;
        for(int i=1;i<nums.Length;i++){
            if(nums[i]!=nums[i-1]){
                if(nums[i]<nums[i-1]){
                    if(state==1)
                        return false;
                    else
                        state=2;
                }
                else{
                    if(state==2)
                        return false;
                    else
                        state=1;
                }
            }
        }
        return true;
    }
}