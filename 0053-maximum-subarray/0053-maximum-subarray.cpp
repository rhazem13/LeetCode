class Solution {
public:
    int maxSubArray(vector<int>& nums) {
        int maxSum=INT_MIN,maxTmp=0;
        for(int i=0;i<nums.size();i++){
            maxTmp=maxTmp+nums[i];
            if(maxTmp>=maxSum){
                maxSum=maxTmp;
            }
            if(maxTmp<0){
                maxTmp=0;
            }
        }
        return maxSum;
    }
};