public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        int i=0;
        List<string> ans=new();
        while(i<nums.Length){
            StringBuilder sb=new();
            sb.Append(nums[i]);
            int tracki=i;
            while(i<nums.Length-1 && nums[i]+1==nums[i+1]){
                i++;
            }
            if(tracki!=i){
                sb.Append("->");
                sb.Append(nums[i]);
            }
            ans.Add(sb.ToString());
            i++;
        }
        return ans;
    }
}