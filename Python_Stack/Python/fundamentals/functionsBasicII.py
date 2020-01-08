#1 Countdown
# def countdown(number):
#     counter = []
#     for x in range(number, -1, -1):
#         counter.append(x)
#     return counter
# print(countdown(5))

#2 Print and Return
# def printReturn(stuff):
#     print(stuff[0])
#     return stuff[1]
# print(printReturn([1,2]))


#3 First Plus Length
# def firstPlusLength(potato):
#     return potato[0] + len(potato)
# print(firstPlusLength([1,2,3,4,5]))

#4 Values Greater than Second
    #Write a function that accepts a list and creates a new list containing only the values from the original list that are greater than its 2nd value. Print how many values this is and then return the new list. If the list has less than 2 elements, have the function return False
# def valuesGreaterThanSecond(potato):
#     new_list = []
#     counter = 0
#     for x in range(len(potato)):
#         if len(potato) < 2:
#             return False
#         if potato[x] > potato[1]:
#             counter += 1
#         if potato[x] > potato[1]:
#             new_list.append(potato[x])
#     print(counter)
#     return new_list
# print(valuesGreaterThanSecond([5,2,3,2,1,4]))
# print(valuesGreaterThanSecond([3]))


#5 This Length, That Value
    #Write a function that accepts two integers as parameters: size and value. The function should create and return a list whose length is equal to the given size, and whose values are all the given value.
     # Example: length_and_value(4,7) should return [7,7,7,7]
     # Example: length_and_value(6,2) should return [2,2,2,2,2,2]
# def thisLengthThatValue(size,value):
#     new_list = []
#     for x in range(0, size, 1):
#         new_list.append(value)
#     return new_list
# print(thisLengthThatValue(4,7))
# print(thisLengthThatValue(6,2))