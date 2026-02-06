public class Solution {
    public int MirrorDistance(int n) {
        long reversed = 0; // Use long to prevent overflow
        int temp = n;

        while (temp > 0) {
            int digit = temp % 10;       // Get last digit
            reversed = reversed * 10 + digit; // Append digit
            temp /= 10;                  // Remove last digit
        }

        // Calculate absolute difference
        return (int)Math.Abs(n - reversed);
    }
}