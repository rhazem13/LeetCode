public class Solution {
    public int ArrangeCoins(int n) {
        return (int)ArrangeCoins((long)n);

    }

    private long ArrangeCoins(long n) {
        if (n == 0) return 0;
        if (n < 3) return 1;

        long left = 2;
        long right = n;

        while (left < right) {
            long mid = left + (right - left) / 2;

            long tempResult = mid * (mid + 1) / 2;

            if (n == tempResult) return mid;
            else if (n < tempResult) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }

        return left - 1;
    }
}