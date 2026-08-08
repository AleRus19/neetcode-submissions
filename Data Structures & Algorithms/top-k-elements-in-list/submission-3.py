class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        d = {}

        for x in nums:
            if x in d:
                d[x] += 1
            else:
                d[x] = 1

        freq_buckets = [[] for _ in range(len(nums) + 1)]

        for num, freq in d.items():
            freq_buckets[freq].append(num)

        res = []

        for bucket in reversed(freq_buckets):
            for num in bucket:
                if k > 0:
                    res.append(num)
                    k -= 1

        return res