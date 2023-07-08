public class Solution {
    public int Maximum69Number (int num) {
        string numberString = num.ToString();
        int count=0;
        foreach(char digitChar in numberString){
            if(digitChar=='6'){
                break;
            }
            else
                count++;
        }
        count=numberString.Length-count-1;
        num-= 6 * (int)Math.Pow(10,count);
        num+= 9 * (int)Math.Pow(10,count);
        return num;
    }
}