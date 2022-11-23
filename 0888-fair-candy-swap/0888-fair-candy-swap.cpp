class Solution {
public:
    vector<int> fairCandySwap(vector<int>& aliceSizes, vector<int>& bobSizes) {
        //i wrote this code at 1:30 am chilling & going to sleep :D
        vector<int> ans(2);
        sort(bobSizes.begin(),bobSizes.end());
        int aliceCandies=0,bobCandies=0;
        for(int i=0;i<aliceSizes.size();i++){
            aliceCandies+=aliceSizes[i];
        }
        for(int i=0;i<bobSizes.size();i++){
            bobCandies+=bobSizes[i];
        }
        for(int i=0;i<aliceSizes.size();i++){
            int seekedNum=(bobCandies+2*aliceSizes[i]-aliceCandies)/2;
            //search using binary d7k
            int l=0;
            int r=bobSizes.size()-1;
            while(l<=r){
            int mid = l + (r-l)/2;
            if(bobSizes[mid]==seekedNum){
                ans[0]=aliceSizes[i];
                ans[1]=seekedNum;
                return ans;
            }
             if (bobSizes[mid] > seekedNum){
                 r=mid-1;
             }
             else{
                 l=mid+1;
             }
            }
        }
        return ans;
    }
};