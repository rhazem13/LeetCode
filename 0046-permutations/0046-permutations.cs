public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<int> tmp=new List<int>();
        IList<IList<int>> result=new List<IList<int>>();
        backtrack(nums,result,tmp);
        return result;
    }

    public void backtrack(int[] nums,IList<IList<int>> result,IList<int> tmp){
        if(tmp.Count==nums.Length){
            result.Add(new List<int>(tmp));
            return;
        }
        else{
            for(int i=0;i<nums.Length;i++){
                if(tmp.Contains(nums[i]))
                    continue;
                tmp.Add(nums[i]);
                backtrack(nums,result,tmp);
                tmp.RemoveAt(tmp.Count-1);
            }
        }
    }

}