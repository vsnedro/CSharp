using System;
using PalindromeLib;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            var s = Console.ReadLine();
            var palindromeFinder = new PalindromeFinder();
            Console.WriteLine($"Longest palindrome is {palindromeFinder.FindLongestPalindrome(s, true, true)}");

            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
