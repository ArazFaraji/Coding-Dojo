#Print all integers from 0 to 150
for x in range(0, 151, 1):
    print(x)


#Print all the multiples of 5 from 5 to 1,000
for x in range(5, 1001, 1):
    if x % 5 == 0:
        print(x)

#Print integers 1 to 1000. If divisible by 5, print "Coding" instead. If divisibile by 10, print "Coding Dojo".
for x in range(1, 101, 1):
    if x % 10 == 0:
        print("Coding Dojo")
    elif x % 5 == 0 and x % 10 != 0:
        print("Coding")
    else:
        print(x)

#Add odd integers from 0 to 500,000, and print the final sum.
sum = 0
for x in range(0,500000,1):
    if x % 2 == 1:
        sum += x
print(sum)

#Print positive numbers starting at 2018, counting down by fours. 
for x in range(2018,-1,-4):
    print(x)

#Flexible Counter
lowNum = 2
highNum = 9
mult = 3
for x in range(lowNum,highNum + 1, 1):
    if x % mult == 0:
        print(x)