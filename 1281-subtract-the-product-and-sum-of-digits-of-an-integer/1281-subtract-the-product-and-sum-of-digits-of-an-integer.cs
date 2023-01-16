public class Solution {
    public int SubtractProductAndSum(int n) {
        List<int> l=new();
        while (n != 0) {
            l.Add(n % 10);
            n /= 10;
        }
        int product=l[0],sum=l[0];
        for(int i=1;i<l.Count;i++){
            product*=l[i];
            sum+=l[i];
        }
        return product-sum;
    }
}