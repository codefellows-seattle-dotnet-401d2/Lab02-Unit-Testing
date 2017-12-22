using War;
using System;
using Xunit;


namespace XUnitTestProject1
{
    public class UnitTest1
    {

        // always returns a random number between 2-13
        [Fact]
        public void CanReturnNumber()
        {
            Assert.InRange(WarGame.Rando(), 2, 13);
        }

        // Note: I can't seem to test the void method, because it is void...

    }
}
