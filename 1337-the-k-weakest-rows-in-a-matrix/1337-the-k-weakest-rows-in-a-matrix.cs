public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        HashSet<int> visited=new();
        List<int> ans=new();
        int minS,minI=0,curS;
        while(k>0){
            minS=Int32.MaxValue;
            for(int i=0;i<mat.Length;i++){
                if(!visited.Contains(i)){
                    curS=0;
                    for(int j=0;j<mat[i].Length;j++){
                        curS+=mat[i][j];
                    }
                    if(curS<minS){
                        minS=curS;
                        minI=i;
                    }
                }
            }
            ans.Add(minI);
            visited.Add(minI);
            k--;
        }
        return ans.ToArray();
    }
}