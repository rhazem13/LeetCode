class Solution {
public:
    vector<int> plusOne(vector<int>& digits) {
        int n=digits.size()-1;
        while(digits[n]==9 && n>0){
            digits[n]=0;
            n--;
        }
        if(n==0 && digits[0]==9){
            digits[0]=1;
            digits.push_back(0);
            return digits;
        }
        digits[n]++;
        return digits;
    }
};