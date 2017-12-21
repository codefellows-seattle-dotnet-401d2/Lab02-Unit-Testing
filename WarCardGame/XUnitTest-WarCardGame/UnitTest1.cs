using System;
using WarCardGame;
using Xunit;

namespace XUnitTest_WarCardGame
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3.1, 2.1, true)]
        [InlineData(14.1, 10.4, true)]
        [InlineData(9.2, 9.1, true)]
        public void CanReturnTrue(double card1, double card2, bool expectedValue)
        {
            Assert.Equal(expectedValue, Game.IsCardOneHigher(card1, card2));
        }

        [Theory]
        [InlineData(2.1, 3.1, false)]
        [InlineData(12.4, 14.1, false)]
        [InlineData(8.1, 8.2, false)]
        public void CanReturnFalse(double card1, double card2, bool expectedValue)
        {
            Assert.Equal(expectedValue, Game.IsCardOneHigher(card1, card2));
        }
    }
}
