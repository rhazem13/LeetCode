public class Solution {
    public int MinOperations(int[] nums, int k) {
        // do an xor operation on the array
        // compare the output of xor to k for ex (011,111)
        // return the number of different bits
        int xorResult = 0;
        foreach (int num in nums){
            xorResult ^= num;
        }
        return CountDifferentBits(xorResult, k);
        
    }
    static int CountDifferentBits(int a, int b)
    {
        int xor = a ^ b;
        int count = 0;

        while (xor != 0)
        {
            count += xor & 1; // Check the least significant bit
            xor >>= 1;        // Shift right by 1 to check the next bit
        }

        return count;
    }
}