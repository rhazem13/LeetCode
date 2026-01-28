public class Solution {
    public int FindClosest(int x, int y, int z) {
        int d1=Math.Abs(x-z);
        int d2=Math.Abs(y-z);
        return d1==d2?0:d1>d2?2:1;
    }
}