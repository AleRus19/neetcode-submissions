public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> dict = [];

        foreach (var ch in s) {
            dict[ch] = dict.GetValueOrDefault(ch) + 1;
        }
        
        for (int i = 0; i < s.Length; i++) {
            if (dict[s[i]] == 1) {
                return i;
            }
        }

        return -1;
    }
}