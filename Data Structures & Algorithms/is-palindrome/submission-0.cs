public class Solution {
    public bool IsPalindrome(string s) {
       var i = 0;
       var j = s.Length - 1;

       while (i <= j) {
            if (!char.IsLetterOrDigit(s[i])) {
                i++;
            } else if (!char.IsLetterOrDigit(s[j])) {
                j--;
            }

            else if (char.ToUpperInvariant(s[i]) != char.ToUpperInvariant(s[j])) {
                return false;
            } else  {
                i++;
                j--;
            }
       }

       return  true;
    }
}
