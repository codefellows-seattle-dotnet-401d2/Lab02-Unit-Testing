using System;
using Xunit;
using CodeCracker;

namespace XUnitTest_CodeCracker
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("spwwz", "hello")]
        public void CanDecode(string expected, string encodedMsg)
        {
            Assert.Equal(expected, HackerTime.Decrypt(encodedMsg));
        }
    }
}