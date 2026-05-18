namespace RomanToInteger;

public class Solution
{
    public int RomanToInt(string s)
    {
        int n = s.Length, result, lastNumber;
        Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000,
        };

        result = dict[s[0]];
        lastNumber = result;

        for (int i = 1; i < n; i++)
        {
            int currentNumber = dict[s[i]];
            if (lastNumber < currentNumber)
            {
                result -= lastNumber;
                result += currentNumber - lastNumber;
            }
            else
            {
                result += currentNumber;
            }

            lastNumber = currentNumber;
        }

        return result;
    }
}