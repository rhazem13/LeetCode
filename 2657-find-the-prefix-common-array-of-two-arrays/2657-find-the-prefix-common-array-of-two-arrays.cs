public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        int[] C = new int[A.Length];
        int[] map = new int[A.Length+1];
        int i=0,tmp,prev=0;
        while(i<A.Length){
            C[i]=prev;
            map[A[i]]++;
            map[B[i]]++;
            if(map[A[i]]==2)
                C[i]++;
            if (A[i] != B[i] && map[B[i]] == 2)
                C[i]++;
            prev=C[i];
            i++;
        }
        return C;
}}