using System;
using Xunit;

namespace XUnitPresentation._00_Basic_Differences
{
    public class XUnitTest : IDisposable
    {
        public XUnitTest()
        {
            // This gets run once for every test
            // replacement for [TestInitialize] or [SetUp]
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

        public void Dispose()
        {
            // This gets run once after every test
            // replacement for [TestCleanup] or [TearDown]
        }
    }
}
