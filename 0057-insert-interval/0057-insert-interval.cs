public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> res=new();
        int i=0;
        //add all intervals before newinterval[0]
        while(i<intervals.Length && intervals[i][1]<newInterval[0]){
            res.Add(intervals[i++]);
        }
        //update newInterval by merging it
        while(i<intervals.Length && intervals[i][0]<=newInterval[1]){
            newInterval[0]=Math.Min(intervals[i][0],newInterval[0]);
            newInterval[1]=Math.Max(intervals[i][1],newInterval[1]);
            i++;
        }
        res.Add(newInterval);
        //add remaining intervals
        while(i<intervals.Length){
            res.Add(intervals[i++]);
        }
        return res.ToArray();
    }
}