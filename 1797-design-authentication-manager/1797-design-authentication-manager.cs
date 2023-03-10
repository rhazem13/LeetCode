public class AuthenticationManager {
    public int ttl;
    Dictionary<string,int> tokens;
    public AuthenticationManager(int timeToLive) {
        this.ttl = timeToLive;
        tokens=new();
    }
    
    public void Generate(string tokenId, int currentTime) {
        tokens.Add(tokenId,currentTime);
    }
    
    public void Renew(string tokenId, int currentTime) {
        if(tokens.ContainsKey(tokenId))
            if(currentTime-tokens[tokenId]<ttl)
                tokens[tokenId]=currentTime;
    }
    
    public int CountUnexpiredTokens(int currentTime) {
        int count=0;
        foreach(var kvp in tokens){
            if(currentTime-kvp.Value<ttl)
                count++;
        }
        return count;
    }
}

/**
 * Your AuthenticationManager object will be instantiated and called as such:
 * AuthenticationManager obj = new AuthenticationManager(timeToLive);
 * obj.Generate(tokenId,currentTime);
 * obj.Renew(tokenId,currentTime);
 * int param_3 = obj.CountUnexpiredTokens(currentTime);
 */