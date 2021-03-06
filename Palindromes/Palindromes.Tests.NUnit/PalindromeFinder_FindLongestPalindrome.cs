using NUnit.Framework;
using PalindromeLib;

namespace Palindromes.Tests.PalindromeLib.NUnit
{
    public class PalindromeFinder_FindLongestPalindrome
    {
        private IPalindromeFinder _palindromeFinder;

        [SetUp]
        public void Setup()
        {
            _palindromeFinder = new PalindromeFinder();
        }

        [Test]
        public void FindLongestPalindrome_EmptyString_Returns_EmptyString()
        {
            var expected = "";
            var actual = _palindromeFinder.FindLongestPalindrome("", false, false);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindLongestPalindrome_123_Returns_EmptyString()
        {
            var expected = "";
            var actual = _palindromeFinder.FindLongestPalindrome("123", false, false);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindLongestPalindrome_12321_Returns_12321()
        {
            var expected = "12321";
            var actual = _palindromeFinder.FindLongestPalindrome("12321", false, false);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindLongestPalindrome_12112321_Returns_12321()
        {
            var expected = "12321";
            var actual = _palindromeFinder.FindLongestPalindrome("12112321", false, false);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindLongestPalindrome_abcba_Returns_abcba()
        {
            var expected = "abcba";
            var actual = _palindromeFinder.FindLongestPalindrome("abcba", false, false);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindLongestPalindrome_ababcba_Returns_abcba()
        {
            var expected = "abcba";
            var actual = _palindromeFinder.FindLongestPalindrome("ababcba", false, false);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindLongestPalindrome_abaBA_WithoutIgnoreCase_Returns_aba()
        {
            var expected = "aba";
            var actual = _palindromeFinder.FindLongestPalindrome("abaBA", false, false);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindLongestPalindrome_abaBA_WithIgnoreCase_Returns_abaBA()
        {
            var expected = "abaBA";
            var actual = _palindromeFinder.FindLongestPalindrome("abaBA", true, false);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindLongestPalindrome_ABAdotBA_WithoutIgnoreSymbols_Returns_ABA()
        {
            var expected = "ABA";
            var actual = _palindromeFinder.FindLongestPalindrome("ABA.BA", false, false);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindLongestPalindrome_ABAdotBA_WithIgnoreSymbols_Returns_ABAdotBA()
        {
            var expected = "ABA.BA";
            var actual = _palindromeFinder.FindLongestPalindrome("ABA.BA", false, true);

            Assert.AreEqual(expected, actual);
        }
    }
}
