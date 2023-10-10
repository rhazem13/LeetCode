public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new();
        List<char> current=new();
        int leftCount=0;
        int rightCount=0;
        backtrack(result,current,n,leftCount,rightCount);
        return result;
    }
    public void backtrack(List<string> result, List<char> current, int n, int leftCount, int rightCount){
        if(leftCount>n || rightCount>n) return;
        if(current.Count>=n*2){
            result.Add(new string(current.ToArray()));
            return;
        }
        if(n>leftCount){
            current.Add('(');
            backtrack(result,current,n,leftCount+1,rightCount);
            current.RemoveAt(current.Count-1);
        }
        if(leftCount>rightCount){
            current.Add(')');
            backtrack(result,current,n,leftCount,rightCount+1);
            current.RemoveAt(current.Count-1);
        }
        return;
    }
}