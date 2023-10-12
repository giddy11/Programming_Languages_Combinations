def ran_func(name: str, age: int, weight: float) -> str:
    print("Name :", name)
    print("Age :", age)
    print("Weight :", weight)

    return "{} is {} years old and weight {}".format(name, age, weight)

print(ran_func("Derek", 41, 165.2))
print(ran_func.__annotations__)