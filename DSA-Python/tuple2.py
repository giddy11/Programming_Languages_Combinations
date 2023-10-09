#!/usr/bin/python3

survey = (27, "Vietman", True)
age = survey[0]
country = survey[1]
knows_python = survey[2]

print("Age= {}".format(age))
print("Country= {}".format(country))
print("Knows Python?= {}".format(knows_python))

survey2 = (21, "Switzerland", True)
age, country, knows_python = survey2
print("Age= {}".format(age))
print("Country= {}".format(country))
print("Knows Python?= {}".format(knows_python))