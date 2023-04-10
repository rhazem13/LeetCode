public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack=new();
        for(int i=0;i<s.Length;i++){
            if(s[i]=='('||s[i]=='{'||s[i]=='[')
                stack.Push(s[i]);
            else{
                if(stack.Count==0) return false;
                if(s[i]==')'){
                    if(stack.Peek()=='(')
                        stack.Pop();
                    else
                        return false;
                }
                else if(s[i]=='}'){
                    if(stack.Peek()=='{')
                        stack.Pop();
                    else
                        return false;
                }
                else if(s[i]==']'){
                    if(stack.Peek()=='[')
                        stack.Pop();
                    else
                        return false;
                }
            }
        }
        return stack.Count()==0;
    }
}