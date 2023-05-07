public class Solution {
   public int FindContentChildren(int[] g, int[] s) {
             if (s.Length == 0)
                return 0;

            var count = 0;
            Array.Sort(g);
            Array.Sort(s);
            int i = g.Length - 1;
            int j = s.Length - 1;

            while (i >= 0 && j >= 0)
            {
                if (g[i] <= s[j])
                {
                    count++;
                    j--;
                }
                i--;
            }
            return count;       
    }
}