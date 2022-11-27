class Solution {
public:
    bool isSubsequence(string s, string t) {
        int sCounter = 0;
	for (int i = 0;i < t.length();i++) {
		if (t[i] == s[sCounter])
			sCounter++;
	}
	return (sCounter == s.length() ? true : false);
    }
};