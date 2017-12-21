using System;
using Xunit;
using CodeCracker;

namespace XUnitTest_CodeCracker
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("xyz", "mno")]
        [InlineData("abc", "!)\"")]
        [InlineData("pkf", "e@*")]
        [InlineData("z a z", "o-!|o")]
        public void CanDecrypt(string expected, string encryptedMsg)
        {
            Assert.Equal(expected, RosettaStone.Decrypt(encryptedMsg));
        }

        [Theory]
        [InlineData("mno", "xyz")]
        [InlineData("!)\"", "abc")]
        [InlineData("e@*", "pkf")]
        [InlineData("! ) \"", "a b c")]
        public void CanEncrypt(string expected, string plainText)
        {
            Assert.Equal(expected, RosettaStone.Encrypt(plainText));
        }
    }
}
