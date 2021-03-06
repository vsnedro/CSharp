using System;
using System.Linq;

namespace PalindromeLib
{
    public class PalindromeFinder : IPalindromeFinder
    {
        public string FindLongestPalindrome(string s, bool ignoreCase, bool ignoreNonLettersAndNonDigits)
        {
            var palindrome = "";
            var compareType = ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;

            string FindPalindromeInternal(string str, int l, int r)
            {
                var result = "";

                // skip non-letters and non-digits
                if (ignoreNonLettersAndNonDigits)
                {
                    while (l > 0 && !char.IsLetterOrDigit(str[l])) l--;
                    while (r < str.Length && !char.IsLetterOrDigit(str[r])) r++;
                }

                while ((l >= 0) && (r < str.Length) && (str[l].ToString().Equals(str[r].ToString(), compareType)))
                {
                    if (r - l + 1 > result.Length)
                    {
                        result = str.Substring(l, r - l + 1);
                    }
                    --l;
                    ++r;
                    // skip non-letters and non-digits
                    if (ignoreNonLettersAndNonDigits)
                    {
                        while (l > 0 && !char.IsLetterOrDigit(str[l])) l--;
                        while (r < str.Length && !char.IsLetterOrDigit(str[r])) r++;
                    }
                }

                return result;
            }

            for (int i = 1; i < s.Length; i++)
            {
                var l = i - 1;
                var r = i;
                var evenPalindrome = FindPalindromeInternal(s, l, r);
                if (evenPalindrome.Length > palindrome.Length)
                {
                    palindrome = evenPalindrome;
                }

                l = i - 1;
                r = i + 1;
                var oddPalindrome = FindPalindromeInternal(s, l, r);
                if (oddPalindrome.Length > palindrome.Length)
                {
                    palindrome = oddPalindrome;
                }
            }

            return palindrome;
        }
    }

    public class PalindromeFinderV1
    {
        public string FindLongestPalindrome(string s)
        {
            var palindrome = "";
            var compareType = StringComparison.CurrentCultureIgnoreCase;

            for (int l = 0; l < s.Length - 1; l++)
            {
                var r = s.LastIndexOf(s[l].ToString(), compareType);

                if ((r > l) && (r - l + 1 > palindrome.Length))
                {
                    var foundPalindrome = false;
                    while (!foundPalindrome && (r > l))
                    {
                        var sl = s.Substring(l, r - l + 1);
                        var sr = new string(sl.ToCharArray().Reverse().ToArray());
                        if (sl.Equals(sr, compareType))
                        {
                            palindrome = sl;
                            foundPalindrome = true;
                        }
                        else
                        {
                            do
                            {
                                --r;
                            } while ((r > l) && (!s[r].ToString().Equals(s[l].ToString(), compareType)));
                        }
                    }
                }

                if (s.Length - l <= palindrome.Length)
                {
                    return palindrome;
                }
            }

            return palindrome;
        }
    }
}