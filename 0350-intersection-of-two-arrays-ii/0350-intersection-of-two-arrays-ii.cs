public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int,int> d=new();
        foreach(var n in nums1){
            if(d.ContainsKey(n))
                d[n]++;
            else
                d.Add(n,1);
        }
        List<int> ans=new();
        foreach(var n in nums2){
            if(d.ContainsKey(n)){
                if(d[n]>0){
                    d[n]--;
                    ans.Add(n);
                }
            }
        }
        return ans.ToArray();
    }
}