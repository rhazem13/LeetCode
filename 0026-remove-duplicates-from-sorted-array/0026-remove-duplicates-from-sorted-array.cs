public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> hashSet=new();
        int k=0;
        for(int i=0;i<nums.Length;i++){
            if(!hashSet.Contains(nums[i])){
                hashSet.Add(nums[i]);
                nums[k]=nums[i];
                k++;
            }
        }
        return k;
    }
}