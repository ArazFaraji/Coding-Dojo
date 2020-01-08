# 1) Biggie Size - 
    # Given a list, write a function that changes all positive numbers in the list to "big".
    # Example: biggie_size([-1, 3, 5, -5]) returns that same list, but whose values are now [-1, "big", "big", -5]
# def biggieSize(potato):
#     for x in range(len(potato)):
#         if potato[x] > 0:
#             potato[x] = 'big'
#     return potato
# print(biggieSize([-1,3,5,-5]))

#2) Count Positives
    #Given a list of numbers, create a function to replace the last value with the number of positive values. (Note that zero is not considered to be a positive number).
        #Example: count_positives([-1,1,1,1]) changes the original list to [-1,1,1,3] and returns it
        #Example: count_positives([1,6,-4,-2,-7,-2]) changes the list to [1,6,-4,-2,-7,2] and returns it
# def countPositives(potato):
#     counter = 0
#     for x in range(len(potato)):
#         if potato[x] > 0:
#             counter += 1
#     potato[len(potato) - 1] = counter
#     return potato
# print(countPositives([-1,1,1,1]))
# print(countPositives([1,6,-4,-2,-7,-2]))

#3 Sum Total
    #Create a function that takes a list and returns the sum of all the values in the array.
        #Example: sum_total([1,2,3,4]) should return 10
        #Example: sum_total([6,3,-2]) should return 7
# def sumTotal(potato):
#     sums = 0
#     for x in range(0, len(potato), 1):
#         sums += potato[x]
#     return sums
# print(sumTotal([1,2,3,4]))
# print(sumTotal([6,3,-2]))


#4 Average
    #Create a function that takes a list and returns the average of all the values.
        #Example: average([1,2,3,4]) should return 2.5
# def average(potato):
#     sums = 0
#     avg = 0
#     for x in range(len(potato)):
#         sums += potato[x]
#     avg = sums / len(potato)
#     return avg
# print(average([1,2,3,4]))


#5 Length
    #Create a function that takes a list and returns the length of the list.
        #Example: length([37,2,1,-9]) should return 4
        #Example: length([]) should return 0
# def length(potato):
#     counter = 0
#     for x in range(len(potato)):
#         counter += 1
#     return counter

# def length(potato):
#     return(len(potato))

# print(length([37,2,1,-9]))
# print(length([]))


#6 Minimum
    #Create a function that takes a list of numbers and returns the minimum value in the list. If the list is empty, have the function return False.
        #Example: minimum([37,2,1,-9]) should return -9
        #Example: minimum([]) should return False
# def minimum(potato):
#     if len(potato) == 0:
#         return False
#     min = potato[0]
#     for x in range(len(potato)):
#         if potato[x] < min:
#             min = potato[x]
#     return min
# print(minimum([37,2,1,-9]))
# print(minimum([]))

#7 Maximum
    #Create a function that takes a list and returns the maximum value in the array. If the list is empty, have the function return False.
        #Example: maximum([37,2,1,-9]) should return 37
        #Example: maximum([]) should return False
# def maximum(potato):
#     if len(potato) == 0:
#         return False
#     max = potato[0]
#     for x in range(len(potato)):
#         if potato[x] > max:
#             max = potato[x]
#     return max
# print(maximum([37,2,1,-9]))
# print(maximum([]))


#8 Ultimate Analysis
    #Create a function that takes a list and returns a dictionary that has the sumTotal, average, minimum, maximum and length of the list.
        #Example: ultimate_analysis([37,2,1,-9]) should return {'sumTotal': 31, 'average': 7.75, 'minimum': -9, 'maximum': 37, 'length': 4 }
# def ultimateAnalysis(potato):
    # # total = 0
    # # avg = 0
    # # min = potato[0]
    # # max = potato[0]
    # # length = 0
    # for x in range(len(potato)):
    #     # length += 1
    #     # total += potato[x]
    #     # if potato[x] < min:
    #     #     min = potato[x]
    #     # if potato[x] > max:
    #     #     max = potato[x]
#     avg = sum(potato) / len(potato)

#     dictionary = {"sumTotal": sum(potato), "average": avg, "minimum": min(potato), "maximum": max(potato), "length": len(potato)}
#     return dictionary.items()
# print(ultimateAnalysis([37,2,1,-9]))


#9 Reverse List
    #Create a function that takes a list and return that list with values reversed. Do this without creating a second list. (This challenge is known to appear during basic technical interviews.)
        #Example: reverse_list([37,2,1,-9]) should return [-9,1,2,37]
# def reverseList(potato):
#     emptyList = []
#     for x in range(len(potato) - 1, -1, -1):
#         emptyList.append(potato[x])
#     return emptyList
# print(reverseList([37,2,1,-9]))

# def reverseList(potato):   # DOES NOT WORK YET
#     for x in range(0, len(potato) / 2, 1):
#         temp = potato[x]
#         potato[x] = potato[len(potato)-x-1]
#         potato[len(potato)-1] = temp
# print(reverseList([37,2,1,-9]))
