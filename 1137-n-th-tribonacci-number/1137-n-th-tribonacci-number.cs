public class Solution {
    public int Tribonacci(int n) {
        if(n==0) return 0;
        int[] a=new int[n+2];
        a[0]=0;
        a[1]=1;
        a[2]=1;
        int i=3;
        while(i<=n){
            a[i]=a[i-1]+a[i-2]+a[i-3];
            i++;
        }
        return a[i-1];
    }
}