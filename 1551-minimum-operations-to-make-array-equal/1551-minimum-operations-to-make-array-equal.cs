public class Solution {
    public int MinOperations(int n) {
        int result=0;
        for(int i=0;i<(n/2)+1;i++){
            int cur=(2*i)+1;
            if(cur<n){
                result+= n-cur;
            }
        }
        return result;
    }
}