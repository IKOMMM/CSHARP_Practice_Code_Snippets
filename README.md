# C# Practise Code Snippets in Console App
Solved tasks for C# practice.

## OOP
### 01: [EMPLOYEES ADDER BASIC](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/CSHARP_Practise_Code_Snippets/%5BOOP%5D%2001/Program.cs)
- Task:
Create a class Human containing the following fields of type private: • name • surname • age. In the Main method of the program create an object of the Human class and assign values to its fields. Next create setting methods and the return values of these properties. In the Main create an object of the Human class and use methods to assign its values
properties. Create an Worker class that extends the Human class. Define public properties: • Position • Hourly Rate. Write a method that will calculate the salary based on the number of hours worked passed in the form of a parameter. Create an object of type Worker and calculate it remuneration based on hours worked. Than create a five-element Employee type array. Data of individual employees should be entered from the console. After all employees' data has been entered the program should display them. 

### 02: [GEOMETRIC FIELD CALCULATOR](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/CSHARP_Practise_Code_Snippets/%5BOOP%5D%2002/Program.cs)
- Task:
Completed and functional geometric field calculator. Create an interface called IFigure. Add a Return Field method to it an float and taking two parameters of type float. Create two classes implementing the interface: Rectangle and Square. Task upgraded to generate Circle, Trapeze, Triangle, Parallelogram and to get user input. 

### 03: [ABSTRACT ANIMAL](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/CSHARP_Practise_Code_Snippets/%5BOOP%5D%2003/Program.cs)
- Task:
Create an interface named IMakingSound with the method MakeSound called without arguments and returns type void, and a second interface named ILand with method HowManyLegs also called without arguments and returning type void. Create a Dog class that implements both interfaces at the same time and contains a Sound property of type string, then create a sample object of this class and call both functions mentioned above. Than create an abstract class named Animal containing age property of type uint and a method called IncreaseAge with no arguments and returning type void. Create an interface named ILadowy with method HowMuchLegs called method called without arguments and returning type void. Create a class Cat that simultaneously inherits from Animal class and implements the ILad interface. Create a sample object of this class and test it.

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

### 05: [TRIM SPACES, REVERSE TEXT, COUNT WORDS, UPPERCASE](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/CSHARP_Practise_Code_Snippets/%5BTABLE%5D%2005/Program.cs)
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

### 04 [EVEN, ODD, PAIR, GREATER THAN ZERO](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/%5BOVERALL%5D%2004/Program.cs)
- Task:
Write a programme that takes an integer, checks its evenness and prints the relevant information on the screen, takes two numbers and checks if both of them are even at the same time, and takes two numbers and checks if at least one of them is greater than zero.

### 05 [FIBONACCI SEQUENCE](https://github.com/IKOMMM/CSHARP_Practice_Code_Snippets/blob/main/CSHARP_Practise_Code_Snippets/%5BOVERALL%5D%2005/Program.cs)
- Task:
Design a recursive function that computes the nth element of a Fibonacci sequence of the form: (F0 = 0, F1 = 1, . . . , Fn = Fn-1 + Fn-2).
