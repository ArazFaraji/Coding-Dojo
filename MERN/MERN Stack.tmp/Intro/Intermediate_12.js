// given a temperature in celcius, return the temperature in farhenheit
function CtoF(temp)
{
    let farhenheit = 0;
    farhenheit = temp * 9/5 + 32;
    return farhenheit
}

console.log(CtoF(100));


// return an array of fibonacci numbers up to some number n


function fibonnacci(n)
{
    let arr = [0, 1];
    var a = 0, b = 1, c = 1;
    for(var i = 2; i <= n; i++)
    {
        c = a + b;
        a = b;
        b = c;
        arr.push(c);
    }
    return arr;
}
console.log(fibonnacci(5))




// count the number of words in a string

function countWords(string)
{
    wordCount = 1
    for(var i = 0; i < string.length; i++)
    {
        if(string[i] == " " && string[i + 1] != " ")
        {
            wordCount += 1
        }
    }
    return wordCount
}
console.log(countWords("Hello I am some words"))

// given an array of numbers, return an array containing the square root of each value

function squareRoot(arr)
{
    for(let i = 0; i < arr.length; i++)
    {
        arr[i] = Math.sqrt(arr[i]);
    }
    return arr;
}
console.log(squareRoot([4,16,81]))


// given a string of words, return the words in opposite order     eg "Hello world" => "world Hello"

function reverseString(string)
{
    var temp = "";
    var splitString = string.split(" ");
    for(var i = splitString.length - 1; i >= 0; i--)
    {
        temp += splitString[i] + " ";
    }
    return temp;
}
console.log(reverseString("Hello these are words"));


// given an array arr and an index x, remove the value at x and shift the values over

