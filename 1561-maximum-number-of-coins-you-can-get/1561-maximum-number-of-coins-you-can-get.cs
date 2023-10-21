public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        int ans=0,n=piles.Length/3,i=piles.Length-2;
        while(n>0){
            ans+=piles[i];
            i-=2;
            n--;
        }
        return ans;
    }
}