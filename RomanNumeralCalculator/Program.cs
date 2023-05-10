using System;

Console.WriteLine(RomanToInt("IV"));
int RomanToInt(string s)
{
    // deinfe data dictionary to map the roman numeral to its value
    Dictionary<char, int> romanMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };

    int result = 0;

    // loop through method input
    for (int i = 0; i < s.Length; i++)
    {
        // if we are not at the end of the string and the current letter is less than the next letter
        if (i != s.Length - 1 && romanMap[s[i]] < romanMap[s[i + 1]])
        {
            // subtract the current letters value to result
            result -= romanMap[s[i]];
        }
        else
        {
            // add the current letters value to result
            result += romanMap[s[i]];
        }
    }

    return result;
}
