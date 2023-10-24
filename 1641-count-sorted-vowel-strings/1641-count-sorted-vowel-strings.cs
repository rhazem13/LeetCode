public class Solution {
    public int CountVowelStrings(int n) {
        return backtrack(n, 0);
    }
    
    public int backtrack(int n, int startingVowel) {
        if (n == 0) {
            return 1;
        }

        int count = 0;
        for (int i = startingVowel; i < 5; i++) {
            count += backtrack(n - 1, i);
        }
        return count;
    }
}
