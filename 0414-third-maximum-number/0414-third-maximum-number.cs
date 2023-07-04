public class Solution {
    public int ThirdMax(int[] nums) {
        var m1=long.MinValue;
        var m2=long.MinValue;
        var m3=long.MinValue;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==m1||nums[i]==m2||nums[i]==m3)
                continue;
            if(nums[i]>m1){
                m3=m2;
                m2=m1;
                m1=nums[i];    
            }
            else if(nums[i]>m2){
                m3=m2;
                m2=nums[i];
            }
            else if(nums[i]>m3){
                m3=nums[i];
            }
        }
        return m3==long.MinValue?(int)m1:(int)m3;
    }
}