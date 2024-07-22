public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
        Array.Sort(deck);
        int[] ans=new int[deck.Length];
        Queue<int> q = new Queue<int>(); 
        for(int i=0;i<deck.Length;i++){
            q.Enqueue(i);
        } 

        foreach(int card in deck){
            ans[q.Dequeue()] = card;
            if(q.Count>0){
                q.Enqueue(q.Dequeue());
            }
        }
        return ans;
    }
}