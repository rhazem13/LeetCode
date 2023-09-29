public class Solution {
    public string CountAndSay(int n) {
        return Helper(n, "1");
    }

    private string Helper(int n, string countAndSay) {
        // Base case
        if (n == 1)
            return countAndSay;

        // Count and say the countAndSay string and recurse
        string newCountAndSay = ExtractCountAndSay(countAndSay);
        return Helper(n - 1, newCountAndSay);
    }

    private string ExtractCountAndSay(string countAndSay) {
        int i = 0;
        StringBuilder res = new StringBuilder();
        
        while (i < countAndSay.Length) {
            char currentChar = countAndSay[i];
            int count = 0;
            
            // Count the number of consecutive identical characters
            while (i < countAndSay.Length && countAndSay[i] == currentChar) {
                count++;
                i++;
            }
            
            // Append the count and the character to the result
            res.Append(count);
            res.Append(currentChar);
        }
        
        return res.ToString();
    }
}
