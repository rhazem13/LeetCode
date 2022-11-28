class Solution {
public:
    bool isValid(string s) {
        stack<char> stack;
        for(int i=0;i<s.length();i++){
            if(s[i]=='('||s[i]=='['||s[i]=='{'){
                stack.push(s[i]);
            }
            else{
                if(stack.empty())
                    return false;
                char tmp=stack.top();
            
                if(s[i]==')' && tmp!='(' || s[i]==']' && tmp!='[' ||
                  s[i]=='}' && tmp!='{'){
                    return false;
                }
                stack.pop();
            }
            }
        if(stack.empty())
            return true;
        else
            return false;
        }
};