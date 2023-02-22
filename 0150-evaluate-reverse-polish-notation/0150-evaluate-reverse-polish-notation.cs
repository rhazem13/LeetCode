public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> s=new();
        s.Push(Convert.ToInt32(tokens[0]));
        int l,r,a;
        for(int i=0;i<tokens.Length;i++){
            if(int.TryParse(tokens[i], out a)){
                s.Push(a);
            }
            else{
                r=s.Pop();
                l=s.Pop();
                switch(tokens[i]){
                    case "+":
                        a=l+r;
                        break;
                    case "-":
                        a=l-r;
                        break;
                    case "*":
                        a=l*r;
                        break;
                    case "/":
                        a=l/r;
                        break;
                }
                s.Push(a);
            }
        }
        return s.Pop();
    }
}