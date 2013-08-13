using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XUnitPresentation._02_Testing_Exceptions
{
    /// <summary>
    /// Summary description for MSTest
    /// </summary>
    [TestClass]
    public class MSTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Method_Under_Test()
        {
            throw new ArgumentException();
        }
    }
}
