public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if (nums == null || nums.Length == 0)
            return new int[] { -1, -1 };
        if (nums.Length==1){
            if(nums[0]==target) return new int[] {0,0};
        }
        // binary search until left is dif num or boundary
        int l=0,m=-1,r=nums.Length-1;
        int[] result = {-1,-1};
        while(l<=r){
            m=(l+r)/2;
            if(nums[m]<target)
                l=m+1;
            if(nums[m]>target)
                r=m-1;
            if(nums[m]==target){
                if(m==0){
                    result[0]=m;
                    break;
                }
                if(nums[m-1]!=target){
                    result[0]=m;
                    break;
                }
                r=m-1;
            }
        }
        m=-1;
        l=0;
        r=nums.Length-1;
        // do same with right
        while(l<=r){
            m=(l+r)/2;
            if(nums[m]<target)
                l=m+1;
            if(nums[m]>target)
                r=m-1;
            if(nums[m]==target){
                if(m==nums.Length-1){
                    result[1]=m;
                    break;
                }
                if(nums[m+1]!=target){
                    result[1]=m;
                    break;
                }
                l=m+1;
            }
        }
        return result;
    }
}