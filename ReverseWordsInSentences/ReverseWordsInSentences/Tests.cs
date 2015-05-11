using System.Linq;
using NUnit.Framework;

namespace ReverseWordsInSentences
{
    [TestFixture]
    class Tests
    {
        [TestCase("", "")]
        [TestCase("Hello World Roberto", "Roberto World Hello")]
        [TestCase("abc abc", "abc abc")]
        [TestCase("foo bar", "bar foo")]
        [TestCase("foos bars", "bars foos")]
        [TestCase("ab", "ab")]
        public void Should_reverse_words(string original, string expected)
        {
            // Arrange
            char[] array = original.ToArray();

            // Act
            var sentence = new Sentence(array);
            sentence.ReverseWords();

            // Assert
            string actual = new string(array);
            Assert.That(array, Is.EqualTo(expected),
                string.Format("Expected: '{0}'\n  Actual:   '{1}'\n             123456789012345678901234567890\n             0        1         2", expected, actual));
        }
    }
}
