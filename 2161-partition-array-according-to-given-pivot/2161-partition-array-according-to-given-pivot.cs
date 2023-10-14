public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int[] result = new int[nums.Length];
        int i=0;
        // first, collect all nums less than pivot
        foreach(int num in nums){
            if(num<pivot){
                result[i]=num;
                i++;
            }
        }
        // then collect all pivots
         foreach(int num in nums){
            if(num==pivot){
                result[i]=num;
                i++;
            }
        }
        // then collect all nums more than pivot
         foreach(int num in nums){
            if(num>pivot){
                result[i]=num;
                i++;
            }
        }
        return result;
    }
}