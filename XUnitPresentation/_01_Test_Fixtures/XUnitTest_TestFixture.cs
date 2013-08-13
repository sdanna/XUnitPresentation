using System;
using Xunit;

namespace XUnitPresentation._01_Test_Fixtures
{
    public class XUnitTest_TestFixture : IUseFixture<XUnitTestDatabaseFixture>
    {
        private static XUnitTestDatabaseFixture _databaseFixture;

        public void SetFixture(XUnitTestDatabaseFixture data)
        {
            _databaseFixture = data;
        }

        [Fact]
        public void Method_Under_Test_1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Method_Under_Test_2()
        {
            Assert.False(false);
        }
    }

    public class XUnitTest2 : IUseFixture<XUnitTestDatabaseFixture>
    {
        private static XUnitTestDatabaseFixture _databaseFixture;

        public void SetFixture(XUnitTestDatabaseFixture data)
        {
            data = _databaseFixture;
        }

        [Fact]
        public void Method_Under_Test()
        {
            Assert.True(true);
        }
    }
}
