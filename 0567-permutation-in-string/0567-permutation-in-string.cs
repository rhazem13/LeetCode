public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char, int> m = new();
        
        for(int idx=0;idx<s1.Length;idx++){
            if(!m.ContainsKey(s1[idx])){
                m[s1[idx]]=0;
            }
            m[s1[idx]]++;
        }
        int l=0,r=s1.Length-1;
        while(r<s2.Length){
            bool contains=true;
            Dictionary<char, int> tmp=new();
            for(int i=l;i<=r;i++){
                if(!tmp.ContainsKey(s2[i])){
                    tmp[s2[i]]=0;
                }
                tmp[s2[i]]++;
            }
            foreach(var key in m.Keys.ToList()){
                if(!tmp.ContainsKey(key)){
                    contains=false;
                    break;
                }
                if(m[key]!=tmp[key])
                    contains=false;
            }
            if(contains)
                return true;
            l++;
            r++;
        }
        return false;
    }
}