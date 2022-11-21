class Solution {
public:
    int pivotIndex(vector<int>& nums) {
        int arrsum=0;
        for(int i=0;i<nums.size();i++){
            arrsum+=nums[i];
        }
        int leftsum=0;
        for (int i=0;i<nums.size();i++){
            if((leftsum==arrsum-leftsum-nums[i])){
                return i;
            }
            leftsum+=nums[i];
        }
        return -1;
    }
};