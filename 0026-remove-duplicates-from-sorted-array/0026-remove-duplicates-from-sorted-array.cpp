class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        int c=1;
        int prev=nums[0];
        for(int i=1;i<nums.size();i++){
            if(nums[i]!=prev){
                nums[c]=nums[i];
                prev=nums[i];
                c++;
            }
        }
        return c;
    }
};