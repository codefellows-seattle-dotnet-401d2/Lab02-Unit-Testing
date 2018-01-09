using System;
using Xunit;
using CodeCracker;

namespace XUnitTest_CodeCracker
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("rst", "ghi")]
        [InlineData("abc", "!)\"")]
        [InlineData("ijk", "><@")]
        
        public void CheckDecrypt(string expected, string encryptMessage)
        {
            Assert.Equal(expected, GettingCryptic.Decrypt(encryptMessage));
        }

        [Theory]
        [InlineData("ghi", "rst")]
        [InlineData("!)\"", "abc")]
        [InlineData("><@", "ijk")]
  
        public void CheckEncrypt(string expected, string words)
        {
            Assert.Equal(expected, GettingCryptic.Encrypt(words));
        }
    }
}