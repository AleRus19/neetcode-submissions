class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        d = {}

        for idx, x in enumerate(nums):
            diff = target - x
            if diff in d:
                return [d[diff], idx]
            else:
                if not x in d:
                    d[x] = idx

        