using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XUnitPresentation._01_Test_Fixtures
{
    /// <summary>
    /// Summary description for MSTest
    /// </summary>
    [TestClass]
    public class MSTest_TestFixture
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {

        }

        [TestInitialize]
        public void TestInitialize()
        {
            
        }

        [TestMethod]
        public void Method_Under_Test_1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Method_Under_Test_2()
        {
            Assert.IsFalse(false);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }
    }
}
