public class Solution {
    public bool isarithmetic(int[] arr){
        // sort el array wb3den em4y
        Array.Sort(arr);
        int d=arr[1]-arr[0];
        for(int i=1;i<arr.Length;i++){
            if(arr[i]-arr[i-1]!=d)
                return false;
        }
        return true;
    }
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
        List<bool> ans = new();
        for(int i=0;i<l.Length;i++){
            ans.Add(isarithmetic(nums.Skip(l[i]).Take(r[i]-l[i]+1).ToArray()));
        }
        return ans;   
    }
}