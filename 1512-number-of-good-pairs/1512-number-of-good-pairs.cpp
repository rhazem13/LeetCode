class Solution {
public:
    int numIdenticalPairs(vector<int>& nums) {
        int ans=0;
        for(int j=0;j<nums.size();j++){
            for(int i=0;i<j;i++){
                if(nums[i]==nums[j]){
                    ans++;
                }
            }
        }
        return ans;
    }
};