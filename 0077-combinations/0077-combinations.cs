public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        List<IList<int>> res=  new List<IList<int>>();
        List<int> tmp = new();
        backtrack(res,tmp,n,k,1);
        return res;
    }
    public void backtrack(IList<IList<int>> res, List<int> tmp, int n, int k,int depth){
        if(tmp.Count==k){
            res.Add(new List<int>(tmp));
            return;
        }
        for(int i=depth;i<=n;i++){
            tmp.Add(i);
            backtrack(res,tmp,n,k,i+1);
            tmp.RemoveAt(tmp.Count-1);
        }
    }
}