public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length==0)
            return 0;
        int v1=nums[0];
        if(nums.Length==1)
            return v1;
        int v2=Math.Max(v1,nums[1]);
        if(nums.Length==2)
            return v2;
        int max=0;
        for(int i=2;i<nums.Length;i++){
            max=Math.Max(nums[i]+v1,v2);
            v1=v2;
            v2=max;
        }
        return max;
    }
}