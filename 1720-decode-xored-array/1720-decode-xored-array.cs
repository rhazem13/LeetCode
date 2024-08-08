public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int[] arr = new int[encoded.Length+1];
        arr[0] = first;
        for(int i=1;i<arr.Length;i++){
            arr[i] = arr[i-1]^encoded[i-1];
        }
        return arr;
    }
}