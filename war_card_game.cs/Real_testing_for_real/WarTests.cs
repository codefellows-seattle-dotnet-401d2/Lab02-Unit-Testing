using System;
using WarCardGame;
using Xunit;

namespace XUnitTest_WarCardGame
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(6.1, 2.1, true)]
        [InlineData(12.1, 9.4, true)]
        [InlineData(8.3, 8.1, true)]
        public void ReturnTrue(double card1, double card2, bool expectedValue)
        {
            Assert.Equal(expectedValue, Game.IsCardOneHigher(card1, card2));
        }

        [Theory]
        [InlineData(2.1, 6.1, false)]
        [InlineData(9.4, 12.1, false)]
        [InlineData(8.1, 8.3, false)]
        public void ReturnFalse(double card1, double card2, bool expectedValue)
        {
            Assert.Equal(expectedValue, Game.IsCardOneHigher(card1, card2));
        }
    }
}
