public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> groups = [];


        foreach (var s  in strs) {
            var signature = new int[26];
            foreach (var c in s) {
                signature[c - 'a']++;
            }
            var key = string.Join(",", signature);

            if (!groups.ContainsKey(key)) {
                groups.Add(key, []);
            }

            groups[key].Add(s);
        }

        return groups.Values.ToList();
        
    }
}
