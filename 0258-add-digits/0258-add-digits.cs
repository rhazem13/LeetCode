public class Solution {
    public int AddDigits(int num) {
        while(num/10>0){
            int newN=0;
            while(num>0){
                int tmp=num%10;
                num/=10;
                newN+=tmp;
            }
            num=newN;
        }
        return num;
    }
}