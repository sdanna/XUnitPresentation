using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace XUnitPresentation._05_Data_Tests
{
    public class XUnitTest_ClassData
    {
        [Theory]
        [ClassData(typeof(BooleanData))]
        public void XUnitTest_ClassData_Test(bool expectedValue, bool actualValue)
        {
            Assert.True(expectedValue == actualValue);
        }
    }

    public class BooleanData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
            {
                new object[] {true, true},
                new object[] {false, false}
            };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}