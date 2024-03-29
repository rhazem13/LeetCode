public class Solution {
    public int Calculate(string s) {
        if(s == null || s == "")
            return 0;
        char operation='+';
        int res=0,num=0;
        Stack<int> stack =new();
        for(int i=0;i<s.Length;i++){
            if(Char.IsDigit(s[i])){
                num=0;
                while(i<s.Length && Char.IsDigit(s[i])){
                    num=10*num+s[i]-'0';
                    i++;
                }
                i--;
            }
            if(s[i]!=' ' || i == s.Length-1){
                if(operation=='+')
                    stack.Push(num);
                else if(operation=='-')
                    stack.Push(-num);
                else if(operation=='*')
                    stack.Push(stack.Pop()*num);
                else if(operation=='/'){
                    stack.Push(stack.Pop()/num);
                }
                operation=s[i];
                num=0;
            }
        }
        int result=0;
        while(stack.Count>0){
            result+=stack.Pop();
        }
        return result;
    }
}