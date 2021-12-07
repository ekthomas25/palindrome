# Palindrome

#### EPICODUS PRACTICE: Lesson 8:11
---
#### By
* _**Ella Tanttu**_
* _**Kate Kiatsiri**_
* _**Liz Thomas**_

## Technologies Used

- Node & NPM
- .net
- C#
- MSTest

## Description

A palindrome is any word, phrase, number, or other sequence of characters that reads the same both backward or forward.

Create a console application that includes a method to identify whether a word is a palindrome. It should return true if the user-provided word is a palindrome and false if it is not.

<!-- ## Setup & Installation Instructions

1. Download or clone github repository to local machine in desired directory - https://github.com/url-path
2. If downloaded, extract .zip contents to desired directory
3. Navigate to and open directory with Visual Studio Code
4. Open terminal and install required packages by typing "npm install"
5. Test code in terminal by typing "npm test"
6. Build the display environment in the terminal by typing "npm run build"
7. Run the environment in your default web browser by typing "npm run start" in the terminal -->

## Known Bugs

No known issues

## License

_MIT Copyright (c) 2021 Ella Tanttu, Liz Thomas, Kate Kiatsiri_
_https://opensource.org/licenses/MIT_

## Contact Information

_Ella Tanttu ellajtanttu@gmail.com_

_Kate Kiatsiri keidsiri@gmail.com_

_Liz Thomas thomas.elizabeth.k@gmail.com_

# Whiteboarding

## Prompt
> A palindrome is any word, phrase, number, or other sequence of characters that reads the same both backward or forward.
>
> Create a console application that includes a method to identify whether a word is a palindrome. It should return true if the user-provided word is a palindrome and false if it is not.
>
> Here are several recommended approaches:
>
> Simpler: There is a method Array.Reverse(). Check it out in the REPL to see what it does.
>
> More Challenging: Create the method without using the Array.Reverse() method. If the simpler way of doing this isn't a challenge, we recommend trying this out!
>
> Bonus Points: Make a method that checks a string of words and also an integer. For example: "Hello olleH" is a palindrome by our definition. An integer palindrome would be: 101.

## Analysis & Brainstorm

Array.Reverse()
String.ToCharArray()

<!-- Check to see if it's an odd or even length string
sdhjgjhds -->

UI
- collect user input: string
- turn string into a variable

-*apply business logic*

- return true or false to user

BL
- class for our isPalindrome
- variable for user input
- variable for array

methods:
- char [] arr = String.ToCharArray();
- Array.Reverse(arr) 
- compare both array if it's equal 
- array1 == array2 

arr variableName = str.ToCharArray(3, 4);

edge cases and other factors:
- capitalization of characters (.toLowercase - c# equiv)
- multiple words? ()


## Pseudocode
      Test must be tabbed in three times to show up as code block: