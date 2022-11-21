class Solution {
public:
    vector<int> smallerNumbersThanCurrent(vector<int>& nums) {
        vector<int> ans(nums.size(),0);
        for(int i=0;i<nums.size();i++){
            for(int j=0;j<nums.size();j++){
                if((j!=i) && nums[j]<nums[i]){
                    ans[i]++;
                }
            }
        }
        return ans;
    }
};