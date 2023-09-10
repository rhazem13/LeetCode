public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int count=0;
        for(int i=0;i<items.Count;i++){
            if((ruleKey=="type" && items[i][0]==ruleValue)||(ruleKey=="color" && items[i][1]==ruleValue)||(ruleKey=="name" && items[i][2]==ruleValue))
            count++;
        }
        return count;
    }
}