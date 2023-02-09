public class Trie {
    class TrieNode {
        public bool isEnd=false;
        public TrieNode[] children = new TrieNode[26];
        public TrieNode(){

        }
    }
    TrieNode root;
    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode cur = root;
        for(int i=0;i<word.Length;i++){
            int id = word[i]-'a';
            if(cur.children[id]==null)
                cur.children[id]=new TrieNode();
            cur=cur.children[id];
        }
        cur.isEnd=true;
    }
    
    public bool Search(string word) {
        TrieNode cur = root;
        for(int i=0;i<word.Length;i++){
            int id=word[i]-'a';
            if(cur.children[id]==null){
                return false;
            }
            cur=cur.children[id];
        }
        return cur.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode cur = root;
        for(int i=0;i<prefix.Length;i++){
            int id=prefix[i]-'a';
            if(cur.children[id]==null){
                return false;
            }
            cur=cur.children[id];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */