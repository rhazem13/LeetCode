public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxsum = nums[0];
        int lastmax = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            // If extending the current subarray is greater than the current element itself,
            // then extend the subarray; otherwise, start a new subarray.
            lastmax = Math.Max(lastmax + nums[i], nums[i]);

            // Update the global maximum if the current subarray sum is greater.
            maxsum = Math.Max(maxsum, lastmax);
        }

        return maxsum;
    }
}
