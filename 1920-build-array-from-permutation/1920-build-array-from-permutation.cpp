class Solution {
public:
    vector<int> buildArray(vector<int>& nums) {
        vector<int> ans (nums);
        for(int i=0;i<nums.size();i++){
            int tmp=nums[i];
            ans[i]=nums[tmp];
        }
        return ans;
    }
};