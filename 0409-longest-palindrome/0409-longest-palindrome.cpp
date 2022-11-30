class Solution {
public:
    int longestPalindrome(string s) {
        int ans=0;
       
        if(s.length()==1)
            return 1;
        vector<int> freq(128);
        for(int i=0;i<s.length();i++){
            freq[s[i]]+=1;
        }
        bool hasExtra=false;
        for(int i=0;i<128;i++){
            if(freq[i]>0){
                if(freq[i]%2!=0){
                    freq[i]--;
                    hasExtra=true;
                }
                ans+=freq[i];
            }
        }
        if(hasExtra)
            ans++;
        return ans;
    }
};