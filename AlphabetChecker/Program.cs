/***
 * AlphabetChecker
 * 
 * Challenge 1: Find out if your sentence contains all the letters of the alphabet
 * Challenge 2: What is the longest common prefix in a sentence
 * 
 * **/

bool continueRunning = true;

while (continueRunning)
{
    Console.WriteLine("\nPlease select an option");
    Console.WriteLine("1. Entire Alphabet Checker");
    Console.WriteLine("2. Longest Common Prefix Checker");
    Console.WriteLine("3. Exit\n");
    int selectedOption = Int32.Parse(Console.ReadLine());

    if (selectedOption == 1)
    {
        Console.WriteLine("================================= Entire Alphabet Checker =============================");
        Console.WriteLine("======== Find out if your sentence contains all the letters of the alphabet ===========");

        Console.WriteLine("\nPlease enter a sentence or phrase");
        string phrase = Console.ReadLine();

        while (String.IsNullOrEmpty(phrase))
        {
            Console.WriteLine("Sentence or phrase cannot be empty. Please enter a sentence or phrase");
            phrase = Console.ReadLine();
        }

        char[] letters = new char[] {'a', 'b', 'c', 'd', 'e', 'f','g', 'h', 'i', 'j', 'k', 'l',
        'm', 'n', 'o', 'p', 'q', 'r','s', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        HashSet<char> missingLetters = new HashSet<char>();

        for (int letter = 0; letter < letters.Length; letter++)
        {
            if (!phrase.Contains(letters[letter]))
            {
                missingLetters.Add(letters[letter]);
            }
        }

        if (missingLetters.Count > 0)
        {
            //Console.WriteLine($"\nYour string does not contain all letters of the alphabet. ");
            Console.WriteLine($"\nYour string does not contain all letters of the alphabet. " +
                $"\nMissing letters are ({string.Join(", ", missingLetters)})");
        }
        else
        {
            Console.WriteLine("\nYour string contains all letters of the alphabet");
        }
    }
    else if (selectedOption == 2)
    {
        Console.WriteLine("=========================== Longest Common Prefix Checker =============================");
        Console.WriteLine("============== What is the longest prefix found in your list of words? =================");

        Console.WriteLine("\nPlease enter a comma separated list of strings (e.g. daisy, dairy, darts)");
        string listOfStrings = Console.ReadLine();
        string[] stringArr = listOfStrings.Split(", ");

        while (stringArr.Length < 2 || String.IsNullOrEmpty(listOfStrings))
        {
            Console.WriteLine("\nYour input is not in the correct format. " +
                "Please enter a comma separated list of strings (e.g. daisy, dairy, darts)");
            listOfStrings = Console.ReadLine();
            stringArr = listOfStrings.Split(", ");
        }

        List<string> longestPrefix = new List<string>();

        //assume first word is the longest prefix
        string prefix = stringArr[0];
        bool found = false;

        while (!found)
        {
            // compare prefix with the rest of elements
            for (int i = 1; i < stringArr.Length; i++)
            {
                // if prefix is found in element, add prefix to list
                if (!String.IsNullOrEmpty(prefix) && stringArr[i].Contains(prefix))
                {
                    longestPrefix.Add(prefix);
                }
            }

            // all remaining elements do not contain the current prefix
            if ((longestPrefix.Count != stringArr.Length - 1) && prefix.Length > 0)
            {
                longestPrefix.Clear();// clear list
                prefix = prefix.Substring(0, prefix.Length - 1); // remove last character from prefix and set new prefix
            }
            else // all remaining elements contain current prefix
            {
                longestPrefix.Clear(); // remove duplicates
                longestPrefix.Add(prefix); // set current prefix
                found = true;
            }
        }

        if (found && !longestPrefix.Contains(""))
        {
            Console.WriteLine($"\nLongest prefix is '{string.Join(", ", longestPrefix)}'");
        }
        else
        {
            Console.WriteLine($"\nWords provided do not share a common prefix");
        }
    }
    else if (selectedOption == 3)
    {
        Console.WriteLine("\nThanks for playing!");
        continueRunning = false;
    }
    else
    {
        Console.WriteLine("\nInvalid option selected");
    }
}

