using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XUnitPresentation._00_Basic_Differences
{
    /// <summary>
    /// Summary description for MSTest
    /// </summary>
    [TestClass]
    public class MSTest
    {
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
    }
}
