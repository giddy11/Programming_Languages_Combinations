#!/usr/bin/python3

tpl1 = ([0,1,2,3,4,5,6,7,8,9])
print(tpl1)
tpl1.append(10)
print(tpl1)
series = tpl1[:-1][::-1]
# print("seires: {}".format(series))
# rev = tpl1[::-1]
tpl1.extend(series)
fin = tuple(tpl1)
print(fin)
