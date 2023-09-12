public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // we need solution better than nlogn
        // make dictionary for each nums[i] store the value [quantity] 
        Dictionary<int,int> dict=new();
        foreach(var n in nums){
            if(dict.ContainsKey(n))
                dict[n]++;
            else
                dict[n]=1;
        }
        // make array with index of count and value of List<int> of nums with that count
        List<int>[] arr = new List<int>[nums.Length + 1];
        // Initialize the inner lists
        for (int i = 0; i <= nums.Length; i++) {
            arr[i] = new List<int>();
        }
        foreach(KeyValuePair<int,int> kvp in dict){
            arr[kvp.Value].Add(kvp.Key);
        }
        // iterate rtl to get k nums
        int[] ans=new int[k];
        int ansIndex=0;
        for (int i = arr.Length - 1; i >= 0 && ansIndex < k; i--) {
            List<int> currentList = arr[i];
            foreach(int num in currentList){
                ans[ansIndex]=num;
                ansIndex++;
                if(ansIndex==k)
                    break;
            }
        }
        return ans;
    }
}