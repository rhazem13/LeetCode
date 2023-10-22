public class Solution {
    public int CountDistinctIntegers(int[] nums) {
        HashSet<int> set=new();
        for(int i=0;i<nums.Length;i++){
            int reverseddigit=reverseDigits(nums[i]);
            set.Add(nums[i]);
            set.Add(reverseddigit);
        }
        return set.Count;
    }
    public int reverseDigits(int num){
        int reverse=0;
        while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
        return reverse;
    }
}