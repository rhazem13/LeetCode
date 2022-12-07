class Solution {
public:
    int characterReplacement(string s, int k) {
           int res = 0, l = s.length();
        if (k >= l) return l;
        vector<int> cnt(26,0);
        int ma = 0,start=0;
        for (int i=0;i<l;i++) {
            cnt[s[i]-'A']++;

            ma = max(cnt[s[i]-'A'], ma);
            int sum = accumulate(cnt.begin(), cnt.end(), 0);
            if (sum - ma > k) {
                cnt[s[start++]-'A']--;
                sum--;
            }
            
            res = max(res, ma + min(k, sum-ma));
        }
        return res;
    }
};