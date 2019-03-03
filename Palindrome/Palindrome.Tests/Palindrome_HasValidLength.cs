using NUnit.Framework;
using Palindrome;

namespace Palindrome.UnitTests
{
    [TestFixture]
    public class Palindrome_HasValidLength
    {
        private readonly Palindrome _palindrome;

        public Setup()
        {
            _palindrome = new Palindrome();
        }

        [Test]
        public void ShouldHaveLengthGreaterThanOne()
        {
            var result = _palindrome.CheckPalindrome("a");
        }
    }
}