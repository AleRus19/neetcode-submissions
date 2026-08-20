public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> dict = [];

        var n = s.Count();
        for (int i = 0; i < n; i++) {
            if (dict.TryGetValue(s[i], out var _)) {
                dict[s[i]]++;
            } else {
                dict[s[i]] = 1;
            }
        }
        
        for (int i = 0; i < n; i++) {
            if (dict[s[i]] == 1) {
                return i;
            }
        }

        return -1;
    }
}