class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        d = {}

        for x in nums:
            if (x in d):
                d[x] += 1
            else:
                d[x] = 1

        max_keys = sorted(d, key=d.get, reverse=True)

        return max_keys[0:k]
        