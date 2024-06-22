using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "hellosannasmith";
        List<string> palindromes = FindPalindromes(input);

        Console.WriteLine("Palindromik alt dizeler:");
        foreach (string palindrome in palindromes)
        {
            Console.WriteLine(palindrome);
        }
    }

    static List<string> FindPalindromes(string input)
    {
        List<string> palindromes = new List<string>();
        int n = input.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j <= n; j++)
            {
                string substring = input.Substring(i, j - i);
                if (IsPalindrome(substring) && substring.Length > 1)
                {
                    palindromes.Add(substring);
                }
            }
        }

        return palindromes;
    }

    static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}

