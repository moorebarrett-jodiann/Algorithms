/***
 * Fizzbuzz: A True Classic
 * 
 * Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" 
 * instead of the number and for the multiples of five print "Buzz". 
 * For numbers which are multiples of both three and five print "FizzBuzz".
 * 
 * Create a loop that follows the "Fizzbuzz" rules, but ONLY counts from 0 to 100 by numbers that produce "fizzbuzz."
 * Create a loop that sums all of the numbers that DON'T result in "fizz," "buzz," or "fizzbuzz."
 * Create a loop that provides a percentage of numbers that don't result in a fizz/buzz
 */

int numCount = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else
    {
        numCount++;
    }
}

double percentile = ((double)numCount / 100) * 100;
Console.WriteLine($"Percentage of numbers that don't result in FizzBuzz are {percentile}%");