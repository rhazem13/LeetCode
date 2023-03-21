public class Solution {
    public int NextGreaterElement(int n) {
        int ans = -1;
        int head = -1;
        int tail = -1;
        string s = n.ToString();
        for(int i=s.Length-1; i>=0; i--)
        {
            for(int j=i-1; j>head; j--)
            {
                if(s[j] < s[i])
                {
                    head = j;
                    tail = i;
                }
            }
        }
        
        if(head != -1)
        {
            string tmp1 = s.Substring(0, head);
            tmp1 += s[tail];
            string tmp2 = s.Substring(head+1, tail-head-1) + s[head];
            if(tail<s.Length-1)
                tmp2+= s.Substring(tail+1, s.Length-tail-1);
            tmp2 = new string(tmp2.OrderBy(c => c).ToArray());
            if(Convert.ToInt64(tmp1+tmp2) <= Int32.MaxValue)
                ans = Convert.ToInt32(tmp1+tmp2);
        }
        
        return ans;
    }
}