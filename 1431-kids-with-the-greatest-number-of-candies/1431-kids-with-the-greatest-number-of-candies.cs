public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int greatest=0;
        foreach(var n in candies)
            if(n>greatest)
                greatest=n;
        bool[] result=new bool[candies.Length];
        for(int i=0;i<candies.Length;i++){
            if(candies[i]+extraCandies>=greatest)
                result[i]=true;
        }
        return result;
    }
}