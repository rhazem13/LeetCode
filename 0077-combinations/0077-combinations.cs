public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        IList<IList<int>> ans=new List<IList<int>>();
        backtrack(ans,new List<int>(),1,n,k);
        return ans;
        
    }
    public void backtrack(IList<IList<int>> combs,List<int> comb,int start,int n,int k){
        if(k==0){
            combs.Add(new List<int>(comb));
            return;
        }
        for(int i=start;i<=n;i++){
            comb.Add(i);
            backtrack(combs,comb,i+1,n,k-1);
            comb.RemoveAt(comb.Count-1);
        }
    }
}