public class Solution {
    public double MinimumAverage(int[] nums) {
        int n=nums.Length;
        double[] averages = new double[n/2];
        Array.Sort(nums);
        double minElement,maxElement;
        for(int i=0;i<n/2;i++){
            minElement = nums[i];
            maxElement = nums[n-1-i];
            averages[i]= (minElement + maxElement) /2;
        }
        return averages.Min();
    }
}