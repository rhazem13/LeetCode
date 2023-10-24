public class Solution {
    public int FindTheWinner(int n, int k) {
        if (n == 1) return 1;

        int winner = 0;

        for (int i = 2; i <= n; i++) {
            winner = (winner + k) % i;
        }

        return winner + 1;
    }
}
