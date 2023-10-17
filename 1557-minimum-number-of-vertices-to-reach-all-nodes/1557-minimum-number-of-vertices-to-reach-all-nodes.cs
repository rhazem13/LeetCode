public class Solution {
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) {
        bool[] hasroute = new bool[n];
        for(int i=0;i<hasroute.Length;i++)
            hasroute[i]=false;
        for(int i=0;i<edges.Count;i++){
            hasroute[edges[i][1]]=true;
        }
        List<int> res = new();
        for(int i=0;i<hasroute.Length;i++){
            if(!hasroute[i])
                res.Add(i);
        }
        return res;
    }
}