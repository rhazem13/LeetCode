public class Solution {
    public bool CanPartition(int[] nums) {
        HashSet<int> set=new();
        int sum=nums.Sum();
        if(sum%2!=0)
            return false;
        int target=sum/2,tmp;
        foreach(var n in nums){
            if(n==target)
                return true;
            foreach(var item in set.ToList()){
                tmp=item+n;
                if(tmp==target)
                    return true;
                if(tmp<target)
                    set.Add(tmp);
            }
            set.Add(n);
        }
        return false;
    }
}