public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stack = new();
        // create a stack keep pushing
        foreach(var c in s){
            // when a star is found pop the stack
            if(c=='*')
                stack.Pop();
            else
                stack.Push(c);
        }
        // finally pop the stack and convert to reversed string
        string output = "";
        while (stack.Count>0)
            output+=stack.Pop();
        char[] charArray = output.ToCharArray();
        Array.Reverse(charArray);
        output = new string(charArray);
        return output;
    }
}