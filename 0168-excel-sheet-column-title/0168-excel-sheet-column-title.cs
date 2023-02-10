public class Solution {
    public string ConvertToTitle(int columnNumber) {
        List<int> list=new();
        int tmp;
        while(columnNumber!=0){
            columnNumber--;
            tmp=columnNumber%26;
            columnNumber/=26;
            list.Add(tmp);
        }
        List<char> ans=new();
        for(int i=list.Count-1;i>-1;i--){
            ans.Add((char)(list[i]+'A'));
        }
        return new string(ans.ToArray());
    }
}