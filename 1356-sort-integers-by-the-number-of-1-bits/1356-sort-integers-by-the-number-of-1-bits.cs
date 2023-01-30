public class Solution {
    public int countSetBits(int n)
        {
            int count = 0;
            while (n > 0) {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
    public int[] SortByBits(int[] arr) {
        Dictionary<int,int> rank=new();
        foreach(var n in arr){
            rank[n]=countSetBits(n);
        }
        int temp;
        for(int i=0;i<arr.Length;i++){
            for(int j=0;j<i;j++){
                if(rank[arr[i]]<rank[arr[j]]){
                    temp=arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp;
                }
                else if(rank[arr[i]]==rank[arr[j]]){
                    if(arr[i]<arr[j]){
                        temp=arr[i];
                        arr[i]=arr[j];
                        arr[j]=temp;
                    }
                }
            }
        }
        return arr;
    }
}