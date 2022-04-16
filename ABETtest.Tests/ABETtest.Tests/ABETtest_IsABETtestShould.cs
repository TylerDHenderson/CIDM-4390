using Xunit;
using ABET.test;

namespace ABET.UnitTests
{
    public class ABETtest_IsABETtestShould
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var abetTest = new ABETtest();
            bool result = abetTest.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}