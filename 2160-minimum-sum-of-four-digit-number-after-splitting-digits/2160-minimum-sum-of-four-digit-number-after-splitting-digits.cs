public class Solution {
    public int MinimumSum(int num) {
        List<int> number=new();
        while(num>0){
            number.Add(num%10);
            num/=10;
        }
        number.Sort();
        return (number[0]*10+number[3])+(number[1]*10+number[2]);
    }
}