public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> d=new();
        foreach(var n in nums){
            d[n]=d.ContainsKey(n)?d[n]+1:1;
            if(d[n]>nums.Length/2)
                return n;
        }
        return -1;
    }
}