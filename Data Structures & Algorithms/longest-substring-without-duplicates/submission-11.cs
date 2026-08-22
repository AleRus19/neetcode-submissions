public class Solution {
    public int LengthOfLongestSubstring(string s) {

        Dictionary<char, int> occ = [];

        var i = 0;
        var j = 0;
        var n = s.Length - 1;
        var max = 0;

        if (n == -1) {
            return 0;
        }

        occ[s[j]] = j;

        while (j <= n) {
            var curMax = j - i + 1;
            max = max > curMax ? max : curMax;

            j++;
            if (j > n) {
                return max;
            }

            if(!occ.ContainsKey(s[j])) {  
                occ[s[j]] = j;
            } else {
                var dst = occ[s[j]] + 1;
                while (i < dst) {
                    occ.Remove(s[i]);
                    i++;
                }
                i = dst;
                occ[s[j]] = j;
            }
        }

        return max;
    }
}
