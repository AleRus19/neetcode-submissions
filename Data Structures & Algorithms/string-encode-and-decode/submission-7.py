class Solution:

    def encode(self, strs: List[str]) -> str:
        res = ""
        lastIdx = len(strs) - 1
        if (lastIdx == - 1):
            return ":#"
        
        for idx, x in enumerate(strs):
            res += x
            if (idx != lastIdx):
                res += ":;"
        return res


    def decode(self, s: str) -> List[str]:
        if s == ":#":
            return []
        return s.split(":;")
