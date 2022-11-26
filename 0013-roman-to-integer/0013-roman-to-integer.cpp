class Solution {
public:
    int romanToInt(string s) {
        int ans=0;
        bool hasMinus=false;
        for(int i=0;i<s.length()-1;i++){
            if(s[i]=='I'){
                if(s[i+1]=='V'||s[i+1]=='X'){
                    ans-=2;
                }
            }
            if(s[i]=='X'){
                if(s[i+1]=='L'||s[i+1]=='C'){
                    ans-=20;
                }
            }
            if(s[i]=='C'){
                if(s[i+1]=='D'||s[i+1]=='M'){
                    ans-=200;
                }
            }
        }
        if(!hasMinus){
            for(int i=0;i<s.length();i++){
                switch(s[i]){
                    case 'I':
                        ans++;
                        break;
                    case 'V':
                        ans+=5;
                        break;
                    case 'X':
                        ans+=10;
                        break;
                    case 'L':
                        ans+=50;
                        break;
                    case 'C':
                        ans+=100;
                        break;
                    case 'D':
                        ans+=500;
                        break;
                    case 'M':
                        ans+=1000;
                        break;
                    case 'Z':
                        continue;
                        break;
                }
            }
        }
        return ans;
    }
};