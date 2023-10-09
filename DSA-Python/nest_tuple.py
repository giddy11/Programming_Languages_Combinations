#!/usr/bin/python3

city = "Edo", "Benin", "Rivers", "Delta"
nums = 1,2,3,4
rep = ("python",)*5

nest = city+nums

# print(nest)
# print(rep)

res = nums[::-1]
print(res)

# NESTING TUPLES IN A LIST
lst = [(1,2,3),(4,5,6)]
print(lst)
lst.append(("Tuple", "Inside", "list"))
print(lst)

# NESTING LIST WITHIN TUPLES
tpl = (['a', 'b', 'c'], ['d', 'e', 'f'])
print(tpl)