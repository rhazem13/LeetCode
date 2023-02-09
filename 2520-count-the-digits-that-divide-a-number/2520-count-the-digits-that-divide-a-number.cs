public class Solution {
    public int CountDigits(int num) {
        List<int> list=new();
        int numcopy=num,digit;
        while(numcopy>0){
            digit=numcopy%10;
            numcopy/=10;
            list.Add(digit);
        }
        int ans=0;
        foreach(var n in list){
            if(num%n==0)
                ans++;
        }
        return ans;
    }
}