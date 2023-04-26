public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<int> prev= new List<int>{1};
        for(int i=1;i<=rowIndex;i++){
            List<int> cur= new List<int>{1};
            for(int j=1;j<i;j++){
                cur.Add(prev[j-1]+prev[j]);
            }
            cur.Add(1);
            prev=cur;
        }
        return prev;
    }
}