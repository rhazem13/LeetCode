public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> ans = new List<IList<int>>();
        List<int> cur = new();
        backtrack(nums,ans,cur,0);
        return ans;
    }
    public void backtrack(int[] nums, IList<IList<int>> ans, List<int> cur, int depth){
        ans.Add(new List<int>(cur));
        for(int i=depth;i<nums.Length;i++){
            cur.Add(nums[i]);
            backtrack(nums,ans,cur,i+1);
            cur.RemoveAt(cur.Count-1);
        }
    }
}