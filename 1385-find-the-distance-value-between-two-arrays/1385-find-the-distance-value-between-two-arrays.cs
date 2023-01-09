public class Solution 
{
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) 
    {
        int result = 0;
        Array.Sort(arr2);
        foreach(var num in arr1)
        {
            int index1 = Array.BinarySearch(arr2, num + d), index2 = Array.BinarySearch(arr2, num - d);
            if(index1 < 0) 
                index1 = ~index1 - 1;
            if(index2 < 0) 
                index2 = ~index2;
            if(index2 > index1)
                result++;
        }
        
        return result;
    }
}