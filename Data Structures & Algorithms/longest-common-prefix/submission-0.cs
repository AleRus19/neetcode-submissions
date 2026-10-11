public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var prefix = "";

        var str = strs[0];


        for(int i = 0; i < str.Length; i++) {
            foreach(var s in strs) {
                if (i > s.Length - 1) {
                    return prefix;
                }

                if (s[i] != str[i]) {
                    return prefix;
                }

            }

            prefix += str[i];
        }

        return prefix;
        
    }
}