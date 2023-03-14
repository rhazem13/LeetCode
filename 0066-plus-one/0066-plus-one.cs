public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> ans=new();
        // start from least significant
        int i=digits.Length-1;
        bool easy=false;
        while(i>-1){
            if(digits[i]<9){
                int x=i+1;
                while(x<digits.Length){
                    digits[x]=0;
                    x++;
                }
                easy=true;
                digits[i]++;
                break;
            }
            i--;
        }
        if(easy)
            return digits;
        ans.Add(1);
        foreach(var n in digits)
            ans.Add(0);
        return ans.ToArray();
    }
}