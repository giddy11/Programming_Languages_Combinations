# import random
# import math
# import collections as col

'''
PROBLEM
    create a func that receives a list and a function
    the func passed will return T or F if a list value
    is odd.
    the surrounding function will return a list of odd
    nos.
'''

'''
STEPS
    def a func that checks for odd numbers
'''

def check_if_odd(num):
    if num % 2 == 0:
        return False
    else:
        return True
    
def funcs_list(list, func):
    oddList = []

    for i in list:
        if func(i):
            oddList.append(i)
        
    return oddList


nums1 = range(1, 20)
print(funcs_list(nums1, check_if_odd))