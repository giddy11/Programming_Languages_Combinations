import random
import math

randList = ["string", 1.234, 28]
oneToTen = list(range(10))
randList = randList + oneToTen

print(randList[0])
print("List Length: {}".format(len(randList)))

print("Index of string: {}".format(randList.index("string")))
print("How many strings: {}".format(randList.count("string")))

first3 = randList[0:3]
for i in first3:
    print("{} : {}".format(first3.index(i), i))

print(first3[0] * 3)

print("Index of string: {}".format(first3.index("string")))
print("How many string: {}".format(first3.count("string")))
first3[0] = "New String"
first3.append("Another")

for i in first3:
    print("{} : {}".format(first3.index(i), i))