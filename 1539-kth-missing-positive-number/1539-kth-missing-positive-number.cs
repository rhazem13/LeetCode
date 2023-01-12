public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        if (arr == null || arr.Length == 0)
            return 0;
        
        int prev = 0,
            count = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (count + arr[i] - prev - 1 >= k)
            {
                k -= count;
                
                while (k-- > 0)
                    prev++;
                
                return prev;
            }
            else
                count += (arr[i] - prev - 1);
            
            prev = arr[i];
        }
        
        return arr[arr.Length - 1] + k - count;
    }
}