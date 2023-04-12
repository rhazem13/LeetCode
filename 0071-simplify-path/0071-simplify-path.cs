public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new();
        List<string> dirs = path.Split('/').ToList();
        foreach(var s in dirs){
            if(s==".."){
                if(stack.Count>0)
                    stack.Pop();
            }
            else if(s=="."||s=="")
                continue;
            else{
                stack.Push(s);
            }

        }
        string result ="/" +string.Join("/",stack.Where(s=>s!="").Reverse());
        if(result.Length>1)
            result=result.TrimEnd('/');
        if(result.Length==0)
            return "/";
        
        return result;
    }
}