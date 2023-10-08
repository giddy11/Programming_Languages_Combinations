#!/usr/bin/python3

nums = [3,10,4,4,9,6,5,7,8,1,2]
# nums.sort()
# nums.reverse()
nums.insert(10, 100)
nums.insert(4, 100)
nums.remove(100)
nums.pop(4)



for i in nums:
    print("{}".format(i))