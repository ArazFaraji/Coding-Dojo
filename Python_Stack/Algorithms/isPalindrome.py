# def isPal(somestring):
#     for x in range(len(somestring) // 2):
#         if(somestring[x] != somestring[len(somestring) - x - 1]):
#             return False
#     return True
# print(isPal("racecar"))


def isPal(somestring):
    string2 = ""
    for x in range(len(somestring) -1, -1, -1):
        string2 += somestring[x]
    if string2 == somestring:
        return True
    else:
        return False
print(isPal("racecar"))