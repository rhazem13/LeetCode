public class Solution {
    public int[][] SortTheStudents(int[][] score, int k) {
        int[][] result = new int[score.Length][];
        SortedDictionary<int,int> sd=new();
        for(int i=0;i<score.Length;i++){
            sd.Add(score[i][k],i);
        }
        // now we have sorted dictionary based on keys and values are old indexes
        int index=score.Length-1;
        foreach(var kvp in sd){
            result[index]=score[kvp.Value];
            index--;
        }
        return result;
    }
}