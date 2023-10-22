public class Solution {
    public int PartitionString(string s) {
        int i=0,ans=0;
        HashSet<char> set=new();
        while(i<s.Length){
            if(!set.Contains(s[i])){
                set.Add(s[i]);
            } else{
                ans++;
                set.Clear();
                set.Add(s[i]);
            }
            if(i==s.Length-1){
                    return ++ans;
                }
            i++;
        }
        return ans;
    }
}