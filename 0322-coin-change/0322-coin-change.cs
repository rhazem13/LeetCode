public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount == 0) return 0;
        Array.Sort(coins);
        int[] dp = new int[amount+1];
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0;
        
        foreach(var coin in coins)
        {
            for(int i = coin; i <=amount; i++)
            {
                if(dp[i-coin] != int.MaxValue)
                {
                    dp[i] = Math.Min(dp[i], dp[i-coin] + 1);
                }
            }
        }
        
        return dp[amount] == int.MaxValue ? -1 : dp[amount];
        
    }
}