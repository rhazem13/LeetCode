public class Solution {
    public int GetWinner(int[] arr, int k) {
        int maxElement = arr[0];
        int consecutiveWins = 0;

        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] > maxElement) {
                maxElement = arr[i];
                consecutiveWins = 1;
            } else {
                consecutiveWins++;
            }

            if (consecutiveWins == k) {
                return maxElement;
            }
        }

        return maxElement;
    }
}
