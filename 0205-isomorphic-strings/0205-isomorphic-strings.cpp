class Solution {
public:
    bool isIsomorphic(string s, string t) {
    int strnlength = s.length();
	char arrs[130];	char arrt[130];

	for (int i = 0;i < 130;i++) {
		arrs[i] = NULL;		arrt[i] = NULL;

	}
	for (int i = 0;i < strnlength;i++) {
		if ((arrs[s[i] - 0] != NULL && arrs[s[i] - 0] != t[i])||(arrt[t[i] - 0] != NULL && arrt[t[i] - 0] != s[i])) {
			return false;
		}
		arrs[s[i] - 0] = t[i];
		arrt[t[i] - 0] = s[i];
	}
	return  true;
    }
};