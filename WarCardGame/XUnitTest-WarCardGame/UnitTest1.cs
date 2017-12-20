using System;
using Xunit;
using WarCardGame;

namespace XUnitTest_WarCardGame
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(32, 21, true)]
        public void CanReturnTrue(int card1, int card2, bool expectedValue)
        {
            Xunit.Assert.Equal(expectedValue, Game.IsCardOneHigher(card1, card2));
        }

        [Theory]
        [InlineData(21, 32, false)]
        public void CanReturnFalse(int card1, int card2, bool expectedValue)
        {
            Xunit.Assert.Equal(expectedValue, Game.IsCardOneHigher(card1, card2));
        }
    }
}
