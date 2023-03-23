public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        
        if (k <= 1) return 0; 
        
        int subarrayCount = 0;
        
        for (int left = 0, right = 0, productSoFar = 1; right < nums.Length; right++)
        {
            productSoFar *= nums[right];
            while (productSoFar >= k) productSoFar /= nums[left++];
            
            int length = right - left + 1;
            
            subarrayCount += length;
        }
        
        return subarrayCount;
    }
}