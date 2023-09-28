public class Solution {
    public bool CanJump(int[] nums) {
        // use a var to track the max index that we can reach
        int maxReach=0;
        for(int i=0;i<nums.Length;i++){
            // if current idx is bigger than max reach index break and return false
            if(i>maxReach)
                return false;
            // update max reach to be max of current max reach or index added to nums[i] (greedy approach)
            maxReach= Math.Max(maxReach, i+nums[i]);
            // if maxReach passed the array length then we made it
            if(maxReach>=nums.Length-1)
                return true;
        }
        return true;
    }
}