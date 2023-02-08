public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int result = nums[0]+nums[1]+nums[nums.Length-1];
        Array.Sort(nums);
        for(int i=0;i<nums.Length-2;i++){
            int ap=i+1;
            int bp=nums.Length-1;
            while(ap<bp){
                int cur=nums[i]+nums[ap]+nums[bp];
                if(cur>target)
                    bp-=1;
                else
                    ap+=1;
                if(Math.Abs(cur-target)<Math.Abs(result-target))
                    result=cur;
            }
        }
        return result;
    }
}