public class Solution {
    public void Rotate(int[] nums, int k) {
       if (nums == null || nums.Length == 0) {
            return;
        }

        int offset = k % nums.Length;
        int count = 0;
        for (int start = 0; count < nums.Length; start++) {
            int current = start;
            int prev = nums[start];
            do {
                int next = (current + offset) % nums.Length;
                int temp = nums[next];
                nums[next] = prev;
                prev = temp;
                current = next;
                count++;
            } while (start != current);
        }
    }
}