class Solution {
public:
    bool backspaceCompare(string s, string t) {
        stack<char> s1;
        stack<char> s2;
        for(int i=0;i<s.length();i++){
            if(s[i]=='#'){
                if(!s1.empty()){
                    s1.pop();
                }
            }
            else{
                    s1.push(s[i]);
                }
        }
        for(int i=0;i<t.length();i++){
            if(t[i]=='#'){
                if(!s2.empty()){
                    s2.pop();
                }
            }
             else{
                    s2.push(t[i]);
                }
        }
        while(true){
            if(s1.empty()&&s2.empty()){
                return true;
            }
            else if(s1.empty()&&!s2.empty())
                return false;
            else if(!s1.empty()&&s2.empty())
                return false;
            
            char c1=s1.top();
            char c2=s2.top();
            if(c1!=c2)
                return false;
            s1.pop();
            s2.pop();
        }
    }
};