public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int[] ans = new int[2];
        int ansIdx=0;
        bool[] exists = new bool[nums.Length];
        for(int i=0;i<exists.Length;i++){
            exists[i]=false;
        }
        for(int i=0;i<nums.Length;i++){
            if(exists[nums[i]]){
                ans[ansIdx]=nums[i];
                ansIdx++;
            } else{
                exists[nums[i]]=true;
            }
        }
        return ans;
    }
}