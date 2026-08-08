class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        d = {}

        for x in nums:
            if (x in d):
                d[x] += 1
            else:
                d[x] = 1

        res = []
        while (k > 0):
            max_key = max(d, key=d.get)
            res.append(max_key)
            del d[max_key]

            k -=1

        return res
        