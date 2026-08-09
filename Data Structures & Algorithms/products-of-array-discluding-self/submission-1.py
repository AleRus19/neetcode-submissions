class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        prefix = [1]
        suffix = [1] * len(nums)

        i = 1
        for x in nums[i:]:
            prefix.append(prefix[i-1] * nums[i-1])
            i = i + 1
        
        j = len(nums) - 2
        while (j >= 0):
            suffix[j] = suffix[j+1] * nums[j+1]
            j = j - 1
        

        return [x*y for x, y in zip(prefix, suffix)]
            
        