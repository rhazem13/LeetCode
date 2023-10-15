public class Solution {
    public IList<IList<int>> FindMatrix(int[] nums) {
        int[] counterArr = new int[nums.Length]; // constrain: [1 <= nums[i] <= nums.length]
        int maxCount = 0; // the count of the number with the most occurrences
        
        for(int i = 0; i < nums.Length; i++){
            counterArr[nums[i] - 1]++; // adding +1 to the counter array
            maxCount = Math.Max(maxCount, counterArr[nums[i]-1]); // checking for new number with the most occurrences
        }

        // initialize list and sub-lists with the given length of max count
        List<IList<int>> result = new List<IList<int>>(maxCount);
        for(int i = 0; i < maxCount; i++)
            result.Add(new List<int>());
        
                
        // for each counterArr[i] add i+1 to all the lists in result
        // e.g if counterArr[i] = 3, add i+1 to result[0], result[1], result[2]
        for(int i = 0; i < counterArr.Length; i++)          
            for(int j = 0; j < counterArr[i]; j++)
                result[j].Add(i+1);                       
                                   
        return result;         
    }
}