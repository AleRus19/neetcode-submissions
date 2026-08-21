public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        Dictionary<char, char> rules = [];

        rules[')'] = '(';
        rules[']'] = '[';
        rules['}'] = '{';
        
        foreach (var c in s) {

            if (c == '(' || c == '[' || c == '{') {
                stack.Push(c);
            } else {
                var open = rules[c];
                if (stack.Count() == 0 || stack.Pop() != open) {
                    return false;
                }
            }
        }

        return stack.Count() == 0;
    }
}
