public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, bool> dict = [];

        var n = s.Count();
        for (int i = 0; i < n; i++) {
            if (dict.TryGetValue(s[i], out var _)) {
                dict[s[i]] = false;
            } else {
                dict[s[i]] = true;
            }
        }
        
        for (int i = 0; i < n; i++) {
            if (dict[s[i]] == true) {
                return i;
            }
        }

        return -1;
    }
}