/***
 * Palindromes
 * 
 * A palindrome is a word that can be spelt the same way forward and backward ("racecar", "deified"). 
 * Write an application that accepts a word from a user (it should reject input that contains any spaces, 
 * or is fewer than three characters long). It should then print whether or not the word is a palindrome.
 */

Console.WriteLine("Please enter a word:");
string word = Console.ReadLine().ToLower();

// convert word to char array
char[] chars = word.ToCharArray();
Array.Reverse(chars);

string reversed = new string(chars);
//Console.WriteLine(word);
//Console.WriteLine(reversed);
if (word == reversed)
{
    Console.WriteLine($"{word} is a Palindrome");
}
else
{
    Console.WriteLine($"{word} is NOT a Palindrome");
}