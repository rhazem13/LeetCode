class Solution {
public:
    vector<int> intersection(vector<int>& nums1, vector<int>& nums2) {
        vector<int> result;
        for(int i=0;i<nums1.size();i++){
            bool exists=false;
            for(int j=0;j<nums2.size();j++){
                if(nums1[i]==nums2[j]){
                    exists=true;
                    break;
                }
            }
            if(exists){
                bool duplicate=false;
                for(int m=0;m<result.size();m++){
                    if(result[m]==nums1[i]){
                        duplicate=true;
                    }
                }
                if(exists && !duplicate){
                    result.push_back(nums1[i]);
                }
            }
            
            }
            
            return result;

        }
};