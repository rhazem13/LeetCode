public class Solution
{
    public bool JudgeSquareSum(int c)
    {
        int left = 0;
        int right = (int)Math.Ceiling(Math.Sqrt(c));
        while (left <= right)
        {
            int sum = left * left + right * right;
            if (sum == c) return true;
			
            if (sum < c && 0 <= sum)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return false;
    }
}