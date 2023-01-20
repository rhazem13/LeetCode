public class Solution {
    public double Average(int[] salary) {
        double min=salary[0],max=salary[0],sum=0;
        for(int i=0;i<salary.Length;i++){
            sum+=salary[i];
            min=salary[i]<min?salary[i]:min;
            max=salary[i]>max?salary[i]:max;
        }
        sum-=min;
        sum-=max;
        return sum/(salary.Length-2);
    }
}