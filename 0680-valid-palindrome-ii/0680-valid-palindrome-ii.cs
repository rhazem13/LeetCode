public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0, right = s.Length - 1;

        while (left < right){
            if (s[left] == s[right]){
                left++;
                right--;
            }else 
                return IsPalindrome(s, left + 1, right) || IsPalindrome(s, left, right - 1);     
        }

        return true;
    }
    private bool IsPalindrome(string s, int left, int right){
        while (left < right){
            if (s[left] != s[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}