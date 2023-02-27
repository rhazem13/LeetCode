public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        //make dict
        Dictionary<int, int> d=new();
        for(int i=30;i<101;i++){
            d.Add(i,-1);
        }
        // iterate reversed
        int min;
        for(int i=temperatures.Length-1;i>-1;i--){
            // for each single temp iterate from it to 100 checking the warmer and git the min dist 
            d[temperatures[i]]=i;
            min=Int32.MaxValue;
            for(int j=temperatures[i]+1;j<101;j++){
                if(d[j]>i)
                    if(d[j]-i<min)
                        min=d[j]-i;
            }
            temperatures[i]=min==Int32.MaxValue?0:min;
        }
        return temperatures;
    }
}