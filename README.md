# C# Practise Code Snippets in Console App
Solved tasks for C# practice.

## TABLES
### 01: [2D ARRAY 4X3](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/%5BTABLE%5D%2001/Program.cs)
- Task:
Create a 2-dimensional array with the size of 4x3 and populate it with whatever values you want.
Then print the contents of the whiteboard on the screen keeping the layout of the whiteboard (therefore 4 rows, 3 columns). Additionally, at the end of the count and print the totals on the screen individual lines. Added subtraction, multiplication, division.  

### 02: [4D ARRAY STORED COORDINATES](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/%5BTABLE%5D%2002/Program.cs)
- Task:
Create a 4-dimensional array of any size and populate it with whatever values you want. Then print n random elements of that table on the screen, printing 4-dimensional coordinates and the stored value. Define for printing a separate, static method that will take two parameters: the array it has to print and the number of items to be printed.

### 03: [JAGGED ARRAY 1..3..5..](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/CSHARP_Practise_Code_Snippets/%5BTABLE%5D%2003/Program.cs)
- Task:
Create a jagged array, which is an array whose elements are arrays. For example, you can create an array of four arrays, where the first array has only one element, the second has, say, three elements, the third has five, and so on. Initialize all arrays and their individual initialize all arrays and their individual elements, and then print them on the screen preserving the array layout (rows, columns).

### 04: [PASCAL'S TRIANGLE](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/CSHARP_Practise_Code_Snippets/%5BTABLE%5D%2004/Program.cs)
- Task:
Write a program that takes an integer m and prints an m-line triangle on the screen Pascal's triangle. As a reminder, there are numbers 1 on the sides of the triangle, and each remaining in the middle is formed as the sum of the two immediately above it.

### 05: [TRIM SPACES, REVERSE TEXT, COUNT WORDS](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/CSHARP_Practise_Code_Snippets/%5BTABLE%5D%2005/Program.cs)
- Task:
Implement a function that removes all whitespace characters from the text passed to it as a call parameter, converts the text of a call parameter into its mirror
reflection, i.e. for "ABC" the function changes the parameter to "CBA" and returns the number of words contained in the text passed to it as a call parameter.

## OVERALL
### 01: [REPLACE VALUES (A=B B=A)](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/%5BOVERALL%5D%2001/Program.cs)
- Task:
Write a program that takes two variables, e.g. a and b, and replaces their values, that means a do the variable b assigns the value to variable a, and the variable a assigns the value to variable b. By itself the substitution should be in the situation that took place in the sales function as arguments you take two variables a and b. To get that your program works, print the contents of both new before and after the swap.

### 02: [TRY...CATCH...FINALY DIVIDE BY ZERO EXCEPTION](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/%5BOVERALL%5D%2002/Program.cs)
- Task:
Write a program that takes two integers from the user, divides the first by the other and displays the result on the screen. In the case where the divisor is equal to 0, division
will throw an exception of type DivideByZeroException which should be handled in a try ... catch ... block, so that instead of breaking the program, a message appears on the screen: "You mustn't divide by zero!". Next rewrite the program so that, apart from displaying the result or a message about divide by 0, in each case, no matter what happens, the program will also say goodbye to the user with a simple message, e.g. "Thank you!"

### 03: [FACTORIAL WITH AN EXCEPTION](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/%5BOVERALL%5D%2003/Program.cs)
- Task:
Write a program that counts factorial of an integer n given by the user and and then prints it out on the screen. The power itself should be counted in a separate static
function, which takes the number n as an argument and returns its power: static int Factorial(int factorialToCount). In case the user tries to type something other than an integer into n, the program should throw an unhandled exception of type ArgumentException.

### 04 [EVEN, ODD, PAIR, GREATER THAN ZERO](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/%5BOVERALL%5D%2004/Program.cs)
- Task:
Write a programme that takes an integer, checks its evenness and prints the relevant information on the screen, takes two numbers and checks if both of them are even at the same time, and takes two numbers and checks if at least one of them is greater than zero.
