public class Solution {
    public string FreqAlphabets(string s) {
        StringBuilder builder=new();
        int i=0;
        int asci;
        while(i<s.Length-2){
            if(s[i+2]=='#'){
                StringBuilder sb=new();
                sb.Append(s[i]);
                sb.Append(s[i+1]);
                asci=Int32.Parse(sb.ToString());
                asci+=96;
                builder.Append((char)asci);
                i+=3;
            }
            else{
                asci=s[i]-'0';
                asci+=96;
                builder.Append((char)asci);
                i++;
            }
        }
        while(i<s.Length){
            asci=s[i]-'0';
                asci+=96;
                builder.Append((char)asci);
                i++;
        }
        return builder.ToString();
    }
}