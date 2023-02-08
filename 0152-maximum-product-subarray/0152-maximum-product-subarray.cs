public class Solution {
    public int MaxProduct(int[] nums) {
        var n = nums.Length;

        if (n == 0) return 0;
        if (n == 1) return nums[0];

        var minArr = new int[n];
        var maxArr = new int[n];

        minArr[0] = nums[0];
        maxArr[0] = nums[0];

        for (int i = 1; i < n; i++) {
            maxArr[i] = Math.Max(Math.Max(maxArr[i - 1] * nums[i], minArr[i - 1] * nums[i]), nums[i]);
            minArr[i] = Math.Min(Math.Min(minArr[i - 1] * nums[i], maxArr[i - 1] * nums[i]), nums[i]);
        }

        return maxArr.Max();

    }
}