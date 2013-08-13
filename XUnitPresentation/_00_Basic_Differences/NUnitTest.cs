using NUnit.Framework;

namespace XUnitPresentation._00_Basic_Differences
{
    [TestFixture]
    public class NUnitTest
    {
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
    }
}