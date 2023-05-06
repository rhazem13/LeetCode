public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int, int> nums_dict=new Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++){
            
                nums_dict[nums[i]]=i;
                
        }
        int [] res=new int[2];
        for(int i=0;i<nums.Length;i++){
            if(nums_dict.ContainsKey(target-nums[i])&&nums_dict[target-nums[i]]!=i){
                res[0]=i;
                res[1]=nums_dict[target-nums[i]];
                break;
            }
        }
        return res;
    }
}