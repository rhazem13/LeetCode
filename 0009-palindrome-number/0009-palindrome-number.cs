public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
            return false;
        List<int> arr=new();
        int tmp;
        while(x>0){
            arr.Add(x%10);
            x/=10;
        }
        int i=0,j=arr.Count-1;
        while(i<j){
            if(arr[i]!=arr[j])
                return false;
            i++;
            j--;
        }
        return true;
    }
}