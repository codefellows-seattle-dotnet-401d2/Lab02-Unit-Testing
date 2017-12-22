using System;
using CardGame;
using Xunit;

namespace XUnitTest_WarCardGame
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(32, 21, true)]
        public void ReturnTrue(int card1, int card2, bool expectedValue)
        {
            Assert.Equal(expectedValue, Game.OneHigh(card1, card2));
        }

        [Theory]
        [InlineData(21, 32, false)]
        public void ReturnFalse(int card1, int card2, bool expectedValue)
        {
            Assert.Equal(expectedValue, Game.OneHigh(card1, card2));
        }
    }
}

