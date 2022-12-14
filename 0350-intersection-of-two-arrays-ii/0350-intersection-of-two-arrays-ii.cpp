class Solution {
public:
    vector<int> intersect(vector<int>& nums1, vector<int>& nums2) {
        vector<int> ans;
        set<int> myset;
        map<int,int> map1;
        map<int,int> map2;
        for(int i=0;i<nums1.size();i++){
            map1[nums1[i]]++;
            myset.insert(nums1[i]);
        }
        for(int i=0;i<nums2.size();i++){
            map2[nums2[i]]++;
        }
        for (const int &number : myset){
            int count=min(map1[number],map2[number]);
            if(count>0){
                while(count>0){
                    ans.push_back(number);
                    count--;
                }
            }
        }
        return ans;
    }
};