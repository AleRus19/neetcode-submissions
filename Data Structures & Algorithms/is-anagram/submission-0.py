class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        d = {}
        for x in s:
            if not x in d:
                d[x] = 1
            else:
                d[x] += 1

        for y in t:
            if not y in d:
                return False
            
            else:
                d[y] -= 1
                if d[y] == 0:
                    del d[y]
        return True