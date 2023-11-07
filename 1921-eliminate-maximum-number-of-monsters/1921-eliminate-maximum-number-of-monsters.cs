public class Solution {
    public int EliminateMaximum(int[] dist, int[] speed) {
        if (dist.Length == 0 || speed.Length == 0) {
            return 0;
        }

        double[] time = new double[dist.Length];
        for (int i = 0; i < dist.Length; i++) {
            time[i] = (double) dist[i] / speed[i];
        }

        Array.Sort(time);

        int count = 0;
        for (int i = 0; i < time.Length; i++) {
            if (time[i] <= i) {
                break;
            }
            count++;
        }

        return count;
    }
}