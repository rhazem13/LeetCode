public class Codec {
    private Dictionary<string,string> storage;
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    int id;
    public Codec(){
        storage = new Dictionary<string,string>();
        id=0;
    }
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        string shortUrl = id.ToString();
        id++;
        storage.Add(shortUrl,longUrl);
        return shortUrl;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        return storage[shortUrl];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));