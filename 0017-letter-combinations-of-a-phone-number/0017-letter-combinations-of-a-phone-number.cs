public class Solution {
    public IList<string> LetterCombinations(string digits) {
        int levels=digits.Length;
        // make array containing string of letters for each index as number
        string[] arr = new string[10];
        arr[2]="abc";
        arr[3]="def";
        arr[4]="ghi";
        arr[5]="jkl";
        arr[6]="mno";
        arr[7]="pqrs";
        arr[8]="tuv";
        arr[9]="wxyz";
        List<string> ans=new();
        if(levels==0)
            return ans;
        // we read input ltr for each char we make a loop 
        int l1=digits[0]-'0';
        foreach(var c1 in arr[l1]){
            if(levels>1){
                int l2=digits[1]-'0';
                foreach(var c2 in arr[l2]){
                    if(levels>2){
                        int l3=digits[2]-'0';
                        foreach(var c3 in arr[l3]){
                            if(levels>3){
                                int l4=digits[3]-'0';
                                foreach(var c4 in arr[l4]){
                                    ans.Add(c1.ToString()+c2.ToString()+c3.ToString()+c4.ToString());
                                }
                            }
                            else{
                                ans.Add(c1.ToString()+c2.ToString()+c3.ToString());
                            }
                        }
                    }
                    else{
                        ans.Add(c1.ToString()+c2.ToString());
                    }
                }
            }
            else{
                ans.Add(c1.ToString());
            }
        }
        return ans;
    }
}