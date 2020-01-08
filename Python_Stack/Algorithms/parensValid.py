# def parensValid(somestring):
#     counter = 0
#     counter2 = 0
#     for x in range(len(somestring)):
#         if somestring[x] == '(':
#             counter += 1
#         if somestring[x] == ')':
#             counter2 += 1
#         if counter2 > counter:
#             return False
#     if counter != counter2:
#         return False
#     if counter == counter2 :
#         return True
# print(parensValid("N(o)t)ok"))


# OR 


def parensValid(somestring):
    count = 0
    for x in range(len(somestring)):
        if somestring[x] == '(':
            counter += 1
        if somestring[x] == ')':
            counter -= 1
        if count < 0:
            return False
    if count != 0:
        return False
    else:
        return True