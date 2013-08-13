using NUnit.Framework;

namespace XUnitPresentation._01_Test_Fixtures
{
    [TestFixture]
    public class NUnitTest_TestFixture
    {
        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            
        }

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void Method_Under_Test_1()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Method_Under_Test_2()
        {
            Assert.False(false);
        }

        [TearDown]
        public void TearDown()
        {
            
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            
        }
    }
}