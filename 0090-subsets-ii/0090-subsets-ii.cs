public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        List<int> tmp = new();
        Array.Sort(nums);
        backtrack(nums,res,0,tmp);
        return res;
    }
    public void backtrack(int[] nums, List<IList<int>> res, int depth, List<int> tmp){
        res.Add(new List<int>(tmp));
        for(int i=depth;i<nums.Length;i++){
            if(i>depth && nums[i]==nums[i-1])continue;
            tmp.Add(nums[i]);
            backtrack(nums,res,i+1,tmp);
            tmp.RemoveAt(tmp.Count-1);
        }
    }
}