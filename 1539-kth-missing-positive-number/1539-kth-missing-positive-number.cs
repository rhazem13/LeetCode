public class Solution {
    public int FindKthPositive(int[] arr, int k) {
    int count = 1;
    int missingCount = 0;
    int i = 0;
    while (i < arr.Length)
    {
        if (arr[i] == count)
        {
            i++;
            count++;
        }
        else
        {
            while (arr[i] != count)
            {
                if (k-1 == missingCount)
                    return count;
                missingCount++;
                count++;
            }
        }
    }
    while (missingCount < k - 1)
    {
        missingCount++;
        count++;
    }
    return count;
}
}