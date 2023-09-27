public class Solution {
    public void NextPermutation(int[] nums) {
        // Start from the right to find i, i+1 where nums[i] < nums[i+1]
        int i = nums.Length - 2;
        while (i >= 0 && nums[i] >= nums[i + 1]) {
            i--;
        }

        // If i is greater than or equal to 0, find the next greater element
        if (i >= 0) {
            int j = nums.Length - 1;
            while (j > i && nums[j] <= nums[i]) {
                j--;
            }
            // Swap nums[i] and nums[j]
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }

        // Reverse the subarray to the right of i
        Reverse(nums, i + 1);
    }

    // Helper function to reverse a subarray
    private void Reverse(int[] nums, int start) {
        int end = nums.Length - 1;
        while (start < end) {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
