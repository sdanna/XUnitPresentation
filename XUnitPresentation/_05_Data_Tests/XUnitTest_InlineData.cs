using System;
using Xunit;
using Xunit.Extensions;

namespace XUnitPresentation._05_Data_Tests
{
    public class XUnitTest_InlineData
    {
        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void Inline_Data_Test(bool expectedValue, bool actualValue)
        {
            Assert.True(expectedValue == actualValue);
        }
    }
}
