class Solution {
public:
    int specialArray(vector<int>& nums) {
        int n=nums.size();
        int counter=0;
        for(int i=0;i<=n;i++){
            counter=0;
            for(int j=0;j<n;j++){
                if(nums[j]>=i){
                    counter++;
                }
            }
            if(counter==i){
                return counter;
            }
        }
        return -1;
    }
};