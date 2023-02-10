public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> s=new();
        if(k>=nums.Length){
            for(int i=0;i<nums.Length;i++){
                if(s.Contains(nums[i]))
                    return true;
                s.Add(nums[i]);
            }
            return false;
        }
        for(int i=0;i<k;i++){
            if(s.Contains(nums[i]))
                return true;
            s.Add(nums[i]);
        }
        int idx=0;
        for(int i=k;i<nums.Length;i++){
            if(s.Contains(nums[i]))
                return true;
            s.Add(nums[i]);
            s.Remove(nums[idx]);
            idx++;
        }
        return false;
    }
}