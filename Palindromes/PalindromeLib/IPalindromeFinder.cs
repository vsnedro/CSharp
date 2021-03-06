using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeLib
{
    public interface IPalindromeFinder
    {
        string FindLongestPalindrome(string s, bool ignoreCase, bool ignoreNonLettersAndNonDigits);
    }
}
