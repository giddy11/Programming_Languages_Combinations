#!/usr/bin/python3

nums = [3,10,4,4,9,6,5,7,8,1,2]
n = len(nums) - 1

for i in range(n):
    for j in range(0, n-i):
        if (nums[j] > nums[j+1]):
            temp = nums[j+1]
            nums[j+1] = nums[j]
            nums[j] = temp


for i in nums:
    print("{}".format(i))