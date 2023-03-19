/***
 * Three Greatest
 * 
 * Write an algorithm for finding the three greatest numbers in a list of numbers. 
 * It should print a new list consisting of these numbers, in order for least to greatest. 
 * 
 * You should not use any built-in functions other than any you need to display data.
 */

Console.WriteLine("Enter the amount of numbers you want for your list:");
int limit = Int32.Parse(Console.ReadLine());
int[] numbers = new int[limit];

for (int i = 0; i < limit; i++)
{
    Console.WriteLine($"Enter #{i + 1}:");
    numbers[i] = Int32.Parse(Console.ReadLine());
}

// initialize all numbers as the first num in element
int largest1 = numbers[0];
int largest2 = numbers[0];
int largest3 = numbers[0];

for (int i = 1; i < numbers.Length - 1; i++)
{
    if (numbers[i] > largest1)
    {
        largest3 = largest2;
        largest2 = largest1;
        largest1 = numbers[i];
    }
    else if (numbers[i] > largest2)
    {
        largest3 = largest2;
        largest2 = numbers[i];
    }
    else if (numbers[i] > largest3)
    {
        largest3 = numbers[i];
    }
}

Console.WriteLine($"The three largest numbers are {largest3}, {largest2} and {largest1}");

/**
 * Example walkthrough
 * list: 12, 45, 99, 101

    int largest1 = 12;
    int largest2 = 12; 
    int largest3 = 12;

    pass1 (num[i] = 45)
        largest3 = largest2;
        largest2 = largest1;
        largest1 = 45;

    pass2 (num[i] = 99)
        largest3 = largest2;
        largest2 = 45;
        largest1 = 99;

    pass3 (num[i] = 101)
        largest3 = 45;
        largest2 = 99;
        largest1 = 101;
    
    Console.WriteLine(largest3, largest2, largest1); // 45, 99, 101
 */