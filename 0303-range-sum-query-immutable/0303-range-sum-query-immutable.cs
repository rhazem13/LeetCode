public class NumArray {

    public int[] nums;
    public NumArray(int[] nums) {
        this.nums=nums;
    }
    
    public int SumRange(int left, int right) {
        int ans=0;
        while(left<=right){
            ans+=nums[left];
            left++;
        }
        return ans;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */