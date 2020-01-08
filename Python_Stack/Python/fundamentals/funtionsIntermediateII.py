#1 Update Values in Dictionaries and Lists
    #Change the value 10 in x to 15. Once you're done, x should now be [ [5,2,3], [15,8,9] ].
    #Change the last_name of the first student from 'Jordan' to 'Bryant'
    #In the sports_directory, change 'Messi' to 'Andres'
    #Change the value 20 in z to 30
# x = [ [5,2,3], [10,8,9] ] 
# students = [
#      {'first_name':  'Michael', 'last_name' : 'Jordan'},
#      {'first_name' : 'John', 'last_name' : 'Rosales'}
# ]
# sports_directory = {
#     'basketball' : ['Kobe', 'Jordan', 'James', 'Curry'],
#     'soccer' : ['Messi', 'Ronaldo', 'Rooney']
# }
# z = [ {'x': 10, 'y': 20} ]

# x[1][0] = 15
# print(x)

# students[0]['last_name'] = "Bryant"
# print(students)

# sports_directory["soccer"][0] = "Andres"
# print(sports_directory)

# z[0]['y'] = 30
# print(z)




#2 Iterate Through a List of Dictionaries
    #Create a function iterateDictionary(some_list) that, given a list of dictionaries, the function loops through each dictionary in the list and prints each key and the associated value. For example, given the following list:

# students = [
#          {'first_name':  'Michael', 'last_name' : 'Jordan'},
#          {'first_name' : 'John', 'last_name' : 'Rosales'},
#          {'first_name' : 'Mark', 'last_name' : 'Guillen'},
#          {'first_name' : 'KB', 'last_name' : 'Tonel'}
#     ]

# iterateDictionary(students) 
# # should output: (it's okay if each key-value pair ends up on 2 separate lines;
# # bonus to get them to appear exactly as below!)
# first_name - Michael, last_name - Jordan
# first_name - John, last_name - Rosales
# first_name - Mark, last_name - Guillen
# first_name - KB, last_name - Tonel

# def iterateDictionary(some_list):
#     for x in range(len(some_list)):
#         for key, val in some_list[x].items():
#             print(key, '-', val)
# iterateDictionary(students)

# def iterateDictionary(some_list):
#     for x in range(len(some_list)):
#         print(f"first_name - {students[x]['first_name']}, last_name - {students[x]['last_name']}")
# iterateDictionary(students)



#3 Get Values from a List of Dictionaries
#     #Create a function iterateDictionary2(key_name, some_list) that, given a list of dictionaries and a key name, the function prints the value stored in that key for each dictionary. 
# def iterateDictionary(key_name, some_list):
#     for x in range(len(some_list)):
#         print(some_list[x].get(key_name))
# # iterateDictionary('first_name',students)
# iterateDictionary('last_name',students)

# def iterateDictionary(key_name, some_list):
#     for item in some_list:
#         print(item[key_name])
# iterateDictionary('first_name',students)



#4 Iterate Through a Dictionary with List Values
    #Create a function printInfo(some_dict) that given a dictionary whose values are all lists, prints the name of each key along with the size of its list, and then prints the associated values within each key's list. For example:
dojo = {
   'locations': ['San Jose', 'Seattle', 'Dallas', 'Chicago', 'Tulsa', 'DC', 'Burbank'],
   'instructors': ['Michael', 'Amy', 'Eduardo', 'Josh', 'Graham', 'Patrick', 'Minh', 'Devon']
    }
# def printInfo(some_dict):
#     for x in some_dict:
#         print(len(some_dict[x]), x.upper())
#         for y in some_dict[x]:
#             print(y) 
# printInfo(dojo)