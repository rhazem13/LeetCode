public class Solution {
    public bool CheckIfExist(int[] arr) {
        HashSet<double> s = new();
        foreach(var n in arr){
            if(s.Contains(n))
                return true;
            s.Add((double)n/2);
            s.Add(n*2);
        }
        return false;
    }
}