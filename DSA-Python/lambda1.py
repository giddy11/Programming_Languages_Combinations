'''
def mult_by_2(num):
    return num * 2

def do_math_times_8(func, num):
    return func(num) * 4



num_times_2 = mult_by_2
math_func = do_math_times_8(mult_by_2, 8)

# print("8 multiplied by 2 is: {}".format(do_math_times_8(mult_by_2, 8)))

list_of_funcs = [num_times_2, do_math_times_8]
print("8 multiplied by 8 is: {}".format(list_of_funcs[1](mult_by_2, 8)))

'''

sum = lambda x, y : x + y
can_vote = lambda age: True if age >= 18 else False
power_list = [lambda x: x ** 2,
              lambda x: x ** 3]
print(sum(3,4))
print("Can vote", can_vote(28))

for func in power_list:
    print(func(4))