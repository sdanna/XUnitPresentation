using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace XUnitPresentation._05_Data_Tests
{
    public class XUnitTest_PropertyData
    {
        [Theory]
        [PropertyData("BooleanData")]
        public void PropertyData_Test(bool expectedValue, bool actualValue)
        {
            Assert.True(expectedValue == actualValue);
        }

        public static IEnumerable<object[]> BooleanData
        {
            get
            {
                // Or this could be read from a file or other source.
                return new[]
                    {
                        new object[] { true, true },
                        new object[] { false, false }
                    };    
            }
        }
    }
}