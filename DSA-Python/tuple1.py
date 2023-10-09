#!/usr/bin/python3

empty_tuple = ()
test1 = ("a",)
test2 = ("a", "b")
test3 = ("a", "b", "c")

test4 = 1,
test5 = 1,2
test6 = 1,2,3

# print(empty_tuple)
# print(test1)
# print(type(test2))
# print(test3)
# print(test4)
# print(test5)
# print(test6)

test6[1] = 6
print(test6[1])


