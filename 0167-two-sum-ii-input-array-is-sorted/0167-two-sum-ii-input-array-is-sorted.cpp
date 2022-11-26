class Solution {
public:
    vector<int> twoSum(vector<int>& numbers, int target) {
      vector<int> ans(2);
        for(int i=0;i<numbers.size();i++){
            //here we do binary search
            int sec=target-numbers[i];
            int l=0;
            int r=numbers.size()-1;
            while(l<=r){
                int m= l +(r-l)/2; 
                if(numbers[m]==sec && m!=i){
                    ans[0]=i+1;
                    ans[1]=m+1;
                    return ans;
                }
                else if(numbers[m]>sec){
                    r=m-1;
                }
                else{
                    l=m+1;
                }
            }
            }
        return ans;
           
        }   
    };
