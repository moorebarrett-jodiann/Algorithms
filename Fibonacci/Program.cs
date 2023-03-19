/***
 * Fibonacci Sequence
 * 
 * Create a loop that asks for a number input, validates that the number given is greater than 1, 
 * and prints numbers in a Fibonacci sequence until they reach that number.
 * Each number in a Fibonacci sequence is the sum of the two preceding values. For example, [1, 1, 2, 3, 5, 8, 13, 21, etc.]
 */

using System;

int firstNum = 1;
int secondNum = 1;
int nextNum;

Console.WriteLine("Please enter a number:");
int userNum = Int32.Parse(Console.ReadLine());

if (userNum < 2)
{
    Console.WriteLine("Please enter a number greater than 2:");
    userNum = Int32.Parse(Console.ReadLine());
}
else
{
    // show first and second number
    Console.Write($"Fibonacci sequence for values up to {userNum} are: {firstNum} {secondNum} ");

    //initialize the next number in sequence
    nextNum = firstNum + secondNum;

    while (nextNum < userNum)
    {
        // evaluate the value of the next number in loop
        nextNum = firstNum + secondNum;

        Console.Write(nextNum + " ");

        // override firstNum with the value of secondNum
        firstNum = secondNum;
        // override secondNum with the value of nextNum
        secondNum = nextNum;
    }
}
