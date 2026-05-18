namespace PolindromeNumber;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        int y = 0, xx = x;

        while (xx > 0)
        {
            y *= 10;
            y += (xx % 10);
            xx /= 10;
        }

        return x == y;
    }
}
