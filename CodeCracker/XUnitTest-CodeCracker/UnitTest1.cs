using System;
using Xunit;
using CodeCracker;

namespace XUnitTest_CodeCracker
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("xyz", "mno")]
        public void CanDecode(string expected, string encodedMsg)
        {
            Assert.Equal(expected, RosettaStone.Decrypt(encodedMsg));
        }
    }
}
