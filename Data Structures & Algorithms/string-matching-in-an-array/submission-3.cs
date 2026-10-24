public class Solution {
    public List<string> StringMatching(string[] words) {
        var res = new List<string>();
        for (int i = 0; i < words.Length; i++) {
            for (int j = 0; j < words.Length; j++) {
                if (i != j && words[i].Contains(words[j])) {
                    if (!res.Contains(words[j])) {
                        res.Add(words[j]);
                    }
                }
            }
        }
        return res;
    }
}