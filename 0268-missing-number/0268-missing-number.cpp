class Solution {
public:
    int missingNumber(vector<int>& nums) {
        int n=nums.size();
        vector<bool> missing(n+1,true);
        for(int i=0;i<n;i++){
            missing[nums[i]]=false;
        }
        for(int i=0;i<=n;i++){
            if(missing[i]==true){
                return i;   
             }
        }
        return -1;
    }
};