class Solution {
public:
    vector<int> shuffle(vector<int>& nums, int n) {
        vector<int> ans (nums);
        int idx=0;
        for(int i=0;i<n;i++){
            ans[idx]=nums[i];
            idx+=2;
        }
        idx=1;
         for(int i=n;i<2*n;i++){
            ans[idx]=nums[i];
            idx+=2;
        }
        return ans;
    }
};