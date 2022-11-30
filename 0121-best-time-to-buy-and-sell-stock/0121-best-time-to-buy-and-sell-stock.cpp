class Solution {
public:
    int maxProfit(vector<int>& prices) {
        vector<int> maxProfits(prices.size());
        int buy=prices[0];
        int maxprofit=0;
        for(int i=0;i<prices.size();i++){
            if(buy>prices[i])
                buy=prices[i];
            else if(prices[i]-buy>maxprofit)
                maxprofit=prices[i]-buy;
        }
        return maxprofit;
    }
};