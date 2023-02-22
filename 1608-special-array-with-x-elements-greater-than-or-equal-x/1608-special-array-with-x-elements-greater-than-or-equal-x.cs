public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);
        // iterate from arr length to 1
        int i=nums.Length;
        int numsGreaterOrEqual;
        while(i>0){
            numsGreaterOrEqual=0;
            foreach(var n in nums){
                if(n>=i)
                    numsGreaterOrEqual++;
            }
            if(numsGreaterOrEqual==i)
                return i;
            i--;
        }
        return -1;
    }
}