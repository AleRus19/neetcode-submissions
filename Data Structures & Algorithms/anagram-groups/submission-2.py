class Solution:

    def isAnagram(self, s: str, t: str) -> bool:
        d = {}

        for x in s:
            if not x in d:
                d[x] = 1
            else:
                d[x] +=1

        for y in t:
            if not y in d:
                return False
            else:
                d[y] -=1
                if d[y] == 0:
                    del d[y]

        return sum(d.values()) == 0


    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        res = []
        for x in strs:
            found = False
            for g in res:
                if self.isAnagram(x, g[0]):
                    g.append(x)
                    found = True
                    break
            if not found:
                res.append([x])
        return res
                    

        