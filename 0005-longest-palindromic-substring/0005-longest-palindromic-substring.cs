public class Solution {
    public string LongestPalindrome(string s) {
        int start = 0; // Initialize the start index of the longest palindromic substring.
        int end = 0;   // Initialize the end index of the longest palindromic substring.

        for (int i = 0; i < s.Length; i++) {
            // Check for odd length palindromes centered at s[i].
            int len1 = ExpandAroundCenter(s, i, i);

            // Check for even length palindromes centered at s[i] and s[i+1].
            int len2 = ExpandAroundCenter(s, i, i + 1);

            // Get the maximum length among these two cases.
            int len = Math.Max(len1, len2);

            if (len > end - start) {
                // If the current palindrome is longer than the previous longest one,
                // update the start and end indices accordingly.
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }

        // Extract and return the longest palindromic substring.
        return s.Substring(start, end - start + 1);
    }

    private int ExpandAroundCenter(string s, int left, int right) {
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }
        return right - left - 1;
    }
}
