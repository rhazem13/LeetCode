using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public IList<string> CommonChars(string[] words) {
        Dictionary<char, int> d1 = new Dictionary<char, int>();
        foreach(char c in words[0]) {
            if (d1.ContainsKey(c)) {
                d1[c]++;
            } else {
                d1[c] = 1;
            }
        }
        for (int i = 1; i < words.Length; i++) {
            Dictionary<char, int> d2 = new Dictionary<char, int>();
            foreach (char c in words[i]) {
                if (d2.ContainsKey(c)) {
                    d2[c]++;
                } else {
                    d2[c] = 1;
                }
            }
            foreach (var kvp in d1.ToList()) {
                char c = kvp.Key;
                if (d2.ContainsKey(c)) {
                    d1[c] = Math.Min(d1[c], d2[c]);
                } else {
                    d1.Remove(c); 
                }
            }
        }
        List<string> answer = new List<string>();
        foreach (var kvp in d1) {
            for (int i = 0; i < kvp.Value; i++) {
                answer.Add(kvp.Key.ToString());
            }
        }
        return answer;
    }
}
