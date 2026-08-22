public class Solution {
    public int LengthOfLongestSubstring(string s) {

        HashSet<char> set = [];

        var i = 0;
        var max = 0;

        for (int j = 0; j < s.Length; j++) {

            while (set.Contains(s[j])) {
                set.Remove(s[i]);
                i++;
            }

            set.Add(s[j]);
            var curMax = j - i + 1;
            max = max > curMax ? max : curMax;
        }

        return max;
    }
}
