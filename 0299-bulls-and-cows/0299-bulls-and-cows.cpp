class Solution {
public:
    string getHint(string secret, string guess) {
        map<char,int> m;
        int bulls=0,cows=0;
        for(int i=0;i<secret.length();i++){
            m[secret[i]]++;
        }
        for(int i=0;i<guess.length();i++){
            if(secret[i]==guess[i]){
                m[secret[i]]--;
                bulls++;
            }
        }
        for(int i=0;i<guess.length();i++){
            // if(secret[i]==guess[i]){
            //     m[secret[i]]--;
            //     bulls++;
            // }
            // else 
            if(m[guess[i]]>0 && secret[i]!=guess[i]){
                m[guess[i]]--;
                cows++;
            }
        }
        return to_string(bulls)+'A'+to_string(cows)+'B';
    }
};