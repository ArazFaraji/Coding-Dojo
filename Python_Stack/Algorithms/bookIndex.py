def bookindex(arr):
    mystring = ""
    myend = ""
    i = 0
    while i < len(arr):
        mybegin = str(arr[i])
        if i != len(arr) -1:
            while arr[i + 1] == arr[i] + 1:
                i += 1
                myend = str(arr[i])
                if i + 1 == len(arr):
                    break
        if myend == "":
            mystring += mybegin
        else:
            mystring += mybegin + " - " + myend
        myend = ""
        if i != len(arr) - 1:
            mystring += ","
        i += 1
    return [mystring]
print(bookindex(arr))
