// Capitalize the first letter of every sentence in a string

using System.Linq;
using System.Text;

string fullString = "hello there. how are you? that's good";
char[] delimiters = new char[] { '.', '?', '!' };

/***
 * Solution #1: Split single string into sentences
 * 
 * Failpoint: splitting by a delimiter does not preserve that delimiter
 * **/

string[] sentences = fullString.Split(delimiters);
Console.WriteLine($"Original String: {fullString}");

foreach (string sentence in sentences)
{
    string newSentence = "";

    // remove trailing and leading whitespaces
    string trimmedSentence = sentence.Trim();

    // make first character uppercase and append the remaining characters in the sentence
    newSentence += char.ToUpper(trimmedSentence[0]) + trimmedSentence.Substring(1);

    Console.WriteLine(newSentence);
}

/***
 * Solution #2: Iterate over each character and add it to a StringBuilder variable until you match a delimiter.
 * 
 * Display the StringBuilder value which will represent our current sentence
 * Clear the StringBuilder value and continue the iteration
 * Add the next string of characters to form a new StringBuilder sentence
 * 
 * Fix for Solution #1: Each sentence preserves its delimiter 
 * **/

StringBuilder sb = new StringBuilder();

for (int i = 0; i < fullString.Length; i++)
{
    sb.Append(fullString[i]);
    if (delimiters.Contains(fullString[i]))
    {
        Console.WriteLine(sb);
        sb.Clear();
    }
}

/***
 * Solution #3: Iterate over each character and extract each sentence along with it's delimiter
 * **/

int startIndex = 0;

for (int i = 0; i < fullString.Length; i++)
{
    if (delimiters.Contains(fullString[i]) || i == fullString.Length - 1)
    {
        string sentence = fullString.Substring(startIndex, i + 1 - startIndex);
        Console.WriteLine(sentence);

        startIndex = i + 1;
    }
}