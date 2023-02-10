public class Solution {
    public int[][] Merge(int[][] intervals) {
        List<int[]> res=new();
        intervals = intervals.OrderBy(i=>i[0]).ToArray();
        int s=intervals[0][0],
            e=intervals[0][1];
        for(int i=1;i<intervals.Length;i++){
            if(intervals[i][0]>e){
                res.Add(new int[] {s,e});
                s=intervals[i][0];
                e=intervals[i][1];
            }
            else
                e=Math.Max(e,intervals[i][1]);
        }
        res.Add(new int[] {s,e});
        return res.ToArray();
    }
}