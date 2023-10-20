public class Solution {
    public void SortColors(int[] nums) {
        int r=0,w=0,b=0;
        foreach(int n in nums){
            if(n==0)r++;
            else if(n==1)w++;
            else b++;
        }
        for(int i=0;i<nums.Length;i++){
            if(r>0){
                nums[i]=0;
                r--;
            } else if(w>0){
                nums[i]=1;
                w--;
            }
            else
                nums[i]=2;
        }
    }
}