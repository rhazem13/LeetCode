    public class Solution
    {
        public int LongestPalindromeSubseq(string s)
        {
            int[,] dp = new int[s.Length, s.Length];

            if (s == null || s.Length == 0)
            {
                return 0;
            }

            if (s.Length == 1)
            {
                return 1;
            }

            for (int length = 1; length <= s.Length; length++)
            {
                for (int start = 0; start < s.Length; start++)
                {
                    int end = start + length - 1;

                    if (end >= s.Length)
                    {
                        break;
                    }

                    if (start == end)
                    {
                        dp[start, end] = 1;
                        continue;
                    }

                    if (length == 2)
                    {
                        dp[start, end] = (s[start] == s[end]) ? 2 : 1;
                        continue;
                    }

                    // use both leftmost and rightmost character
                    if (s[start] == s[end])
                    {
                        dp[start, end] = Math.Max(dp[start, end], dp[start + 1, end - 1] + 2);
                    }

                    //use rightmost char only
                    dp[start, end] = Math.Max(dp[start, end], dp[start + 1, end]);

                    //use leftmost char only
                    dp[start, end] = Math.Max(dp[start, end], dp[start, end - 1]);
                }
            }

            return dp[0, s.Length - 1];
        }
    }